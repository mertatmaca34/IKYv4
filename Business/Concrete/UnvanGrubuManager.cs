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
    public class UnvanGrubuManager : IUnvanGrubuManager
    {
        readonly IUnvanGrubuDal _unvanGrubuDal;

        public UnvanGrubuManager(IUnvanGrubuDal unvanGrubuDal)
        {
            _unvanGrubuDal = unvanGrubuDal;
        }

        public IResult Add(UnvanGrubu unvanGrubu)
        {
            IResult result = BusinessRules.Run(CheckUnvanGrubuExist(unvanGrubu));

            if (result == null)
            {
                this.Update(unvanGrubu);

                return new SuccessResult(Messages.UnvanGrubuUpdated);
            }
            else if (result != null)
            {
                _unvanGrubuDal.Add(unvanGrubu);

                return new SuccessResult(Messages.UnvanGrubuAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(UnvanGrubu unvanGrubu)
        {
            IResult result = BusinessRules.Run(CheckUnvanGrubuExist(unvanGrubu));

            if (result == null)
            {
                _unvanGrubuDal.Delete(unvanGrubu);

                return new SuccessResult(Messages.UnvanGrubuDeleted);
            }

            return new ErrorDataResult<UnvanGrubu>(Messages.InvalidDelete);
        }

        public IDataResult<List<UnvanGrubu>> GetAll(Expression<Func<UnvanGrubu, bool>> filter = null)
        {
            var data = _unvanGrubuDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<UnvanGrubu>>(data);
            }
            else
            {
                return new SuccessDataResult<List<UnvanGrubu>>(data);
            }
        }

        public IResult Update(UnvanGrubu unvanGrubu)
        {
            IResult result = BusinessRules.Run(CheckUnvanGrubuExist(unvanGrubu));

            if (result == null)
            {
                var existEntity = _unvanGrubuDal.GetAll().Where(c => c.Id == unvanGrubu.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    unvanGrubu.Id = existEntity.Id;

                    _unvanGrubuDal.Update(unvanGrubu);

                    return new SuccessResult(Messages.UnvanGrubuUpdated);
                }
            }

            this.Add(unvanGrubu);

            return new SuccessResult(Messages.UnvanGrubuAdded);
        }
        private IResult CheckUnvanGrubuExist(UnvanGrubu unvanGrubu)
        {
            if (unvanGrubu != null)
            {
                var data = _unvanGrubuDal.GetAll();

                var filteredData = data.Where(d => d.Id == unvanGrubu.Id).FirstOrDefault();

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