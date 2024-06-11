using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class UnvanManager : IUnvanManager
    {
        readonly IUnvanDal _unvanDal;

        public UnvanManager(IUnvanDal unvanDal)
        {
            _unvanDal = unvanDal;
        }

        public IResult Add(Unvan unvan)
        {
            IResult result = BusinessRules.Run(CheckUnvanExist(unvan));

            if (result == null)
            {
                this.Update(unvan);

                return new SuccessResult(Messages.UnvanUpdated);
            }
            else if (result != null)
            {
                _unvanDal.Add(unvan);

                return new SuccessResult(Messages.UnvanAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Unvan unvan)
        {
            IResult result = BusinessRules.Run(CheckUnvanExist(unvan));

            if (result == null)
            {
                _unvanDal.Delete(unvan);

                return new SuccessResult(Messages.UnvanDeleted);
            }

            return new ErrorDataResult<Unvan>(Messages.InvalidDelete);
        }

        public IDataResult<List<Unvan>> GetAll(Expression<Func<Unvan, bool>> filter = null)
        {
            var data = _unvanDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<Unvan>>(data);
            }
            else
            {
                return new SuccessDataResult<List<Unvan>>(data);
            }
        }

        public IResult Update(Unvan unvan)
        {
            IResult result = BusinessRules.Run(CheckUnvanExist(unvan));

            if (result == null)
            {
                var existEntity = _unvanDal.GetAll().Where(c => c.Id == unvan.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    unvan.Id = existEntity.Id;

                    _unvanDal.Update(unvan);

                    return new SuccessResult(Messages.UnvanUpdated);
                }
            }

            this.Add(unvan);

            return new SuccessResult(Messages.UnvanAdded);
        }
        private IResult CheckUnvanExist(Unvan unvan)
        {
            if (unvan != null)
            {
                var data = _unvanDal.GetAll();

                var filteredData = data.Where(d => d.Id == unvan.Id).FirstOrDefault();

                if (filteredData != null)
                {
                    return new SuccessResult();
                }
                else
                {
                    return new ErrorResult(Messages.DataNotFound);
                }
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }
    }
}