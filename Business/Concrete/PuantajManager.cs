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
    public class PuantajManager : IPuantajManager
    {
        readonly IPuantajDal _puantajDal;

        public PuantajManager(IPuantajDal puantajDal)
        {
            _puantajDal = puantajDal;
        }

        public IResult Add(Puantaj puantaj)
        {
            IResult result = BusinessRules.Run(CheckPuantajExist(puantaj));

            if (result == null)
            {
                this.Update(puantaj);

                return new SuccessResult(Messages.PuantajUpdated);
            }
            else if (result != null)
            {
                _puantajDal.Add(puantaj);

                return new SuccessResult(Messages.PuantajAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Puantaj puantaj)
        {
            IResult result = BusinessRules.Run(CheckPuantajExist(puantaj));

            if (result == null)
            {
                _puantajDal.Delete(puantaj);

                return new SuccessResult(Messages.PuantajDeleted);
            }

            return new ErrorDataResult<Puantaj>(Messages.InvalidDelete);
        }

        public IDataResult<List<Puantaj>> GetAll(Expression<Func<Puantaj, bool>> filter = null)
        {
            var data = _puantajDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<Puantaj>>(data);
            }
            else
            {
                return new SuccessDataResult<List<Puantaj>>(data);
            }
        }

        public IResult Update(Puantaj puantaj)
        {
            IResult result = BusinessRules.Run(CheckPuantajExist(puantaj));

            if (result == null)
            {
                var existEntity = _puantajDal.GetAll().Where(c => c.AdiSoyadi == puantaj.AdiSoyadi && c.YilAy == puantaj.YilAy).FirstOrDefault();

                if (existEntity != null)
                {
                    puantaj.Id = existEntity.Id;

                    _puantajDal.Update(puantaj);

                    return new SuccessResult(Messages.PuantajUpdated);
                }
            }

            this.Add(puantaj);

            return new SuccessResult(Messages.PuantajAdded);
        }

        private IResult CheckPuantajExist(Puantaj puantaj)
        {
            if (puantaj != null)
            {
                var data = _puantajDal.GetAll();

                var filteredData = _puantajDal.GetAll().Where(c => c.AdiSoyadi == puantaj.AdiSoyadi && c.YilAy == puantaj.YilAy).FirstOrDefault();

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