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
    public class IzinManager : IIzinManager
    {
        readonly IIzinDal _izinDal;

        public IzinManager(IIzinDal izinDal)
        {
            _izinDal = izinDal;
        }

        public IResult Add(Izin izin)
        {
            IResult result = BusinessRules.Run(CheckIzinExist(izin));

            if (result == null)
            {
                this.Update(izin);

                return new SuccessResult(Messages.IzinUpdated);
            }
            else if (result != null)
            {
                _izinDal.Add(izin);

                return new SuccessResult(Messages.IzinAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Izin izin)
        {
            IResult result = BusinessRules.Run(CheckIzinExist(izin));

            if (result == null)
            {
                _izinDal.Delete(izin);

                return new SuccessResult(Messages.IzinDeleted);
            }

            return new ErrorDataResult<Izin>(Messages.InvalidDelete);
        }

        public IDataResult<List<Izin>> GetAll(Expression<Func<Izin, bool>> filter = null)
        {
            var data = _izinDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<Izin>>(data);
            }
            else
            {
                return new SuccessDataResult<List<Izin>>(data);
            }
        }

        public IResult Update(Izin izin)
        {
            IResult result = BusinessRules.Run(CheckIzinExist(izin));

            if (result == null)
            {
                var existEntity = _izinDal.GetAll().Where(c => c.Id == izin.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    izin.Id = existEntity.Id;

                    _izinDal.Update(izin);

                    return new SuccessResult(Messages.IzinUpdated);
                }
            }

            this.Add(izin);

            return new SuccessResult(Messages.IzinAdded);
        }
        private IResult CheckIzinExist(Izin izin)
        {
            if (izin != null)
            {
                var data = _izinDal.GetAll();

                var filteredData = data.Where(d => d.Id == izin.Id).FirstOrDefault();

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