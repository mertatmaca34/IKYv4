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
    public class CocukManager : ICocukManager
    {
        readonly ICocukDal _cocukDal;

        public CocukManager(ICocukDal cocukDal)
        {
            _cocukDal = cocukDal;
        }

        public IResult Add(Cocuk cocuk)
        {
            IResult result = BusinessRules.Run(CheckCocukExist(cocuk));

            if (result == null)
            {
                this.Update(cocuk);

                return new SuccessResult(Messages.CocukUpdated);
            }
            else if (result != null)
            {
                _cocukDal.Add(cocuk);

                return new SuccessResult(Messages.CocukAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Cocuk cocuk)
        {
            IResult result = BusinessRules.Run(CheckCocukExist(cocuk));

            if (result == null)
            {
                _cocukDal.Delete(cocuk);

                return new SuccessResult(Messages.CocukDeleted);
            }

            return new ErrorDataResult<Cocuk>(Messages.InvalidDelete);
        }

        public IDataResult<List<Cocuk>> GetAll(Expression<Func<Cocuk, bool>> filter = null)
        {
            return new SuccessDataResult<List<Cocuk>>(_cocukDal.GetAll(filter));
        }

        public IResult Update(Cocuk cocuk)
        {
            IResult result = BusinessRules.Run(CheckCocukExist(cocuk));

            if (result == null)
            {
                var existEntity = _cocukDal.GetAll().Where(c => c.Id == cocuk.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    cocuk.Id = existEntity.Id;

                    _cocukDal.Update(cocuk);

                    return new SuccessResult(Messages.CocukUpdated);
                }
            }

            this.Add(cocuk);

            return new SuccessResult(Messages.CocukAdded);
        }
        private IResult CheckCocukExist(Cocuk cocuk)
        {
            if (cocuk != null)
            {
                var data = _cocukDal.GetAll();

                var filteredData = data.Where(d => d.Id == cocuk.Id).FirstOrDefault();

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