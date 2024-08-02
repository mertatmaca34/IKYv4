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
    public class IletisimManager : IIletisimManager
    {
        readonly IIletisimDal _iletisimDal;

        public IletisimManager(IIletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public IResult Add(Iletisim iletisim)
        {
            IResult result = BusinessRules.Run(CheckIletisimExist(iletisim));

            if (result == null)
            {
                this.Update(iletisim);

                return new SuccessResult(Messages.CalismaSaatleriUpdated);
            }
            else if (result != null)
            {
                _iletisimDal.Add(iletisim);

                return new SuccessResult(Messages.NufusAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Iletisim iletisim)
        {
            IResult result = BusinessRules.Run(CheckIletisimExist(iletisim));

            if (result == null)
            {
                _iletisimDal.Delete(iletisim);

                return new SuccessResult(Messages.CalismaSaatleriDeleted);
            }

            return new ErrorDataResult<Iletisim>(Messages.InvalidDelete);
        }

        public IDataResult<List<Iletisim>> GetAll(Expression<Func<Iletisim, bool>> filter = null)
        {
            return new SuccessDataResult<List<Iletisim>>(_iletisimDal.GetAll(filter));
        }

        public IResult Update(Iletisim iletisim)
        {
            IResult result = BusinessRules.Run(CheckIletisimExist(iletisim));

            if (result == null)
            {
                var existEntity = _iletisimDal.GetAll().Where(c => c.Id == iletisim.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    iletisim.Id = existEntity.Id;

                    _iletisimDal.Update(iletisim);

                    return new SuccessResult(Messages.CalismaSaatleriUpdated);
                }
            }

            this.Add(iletisim);

            return new SuccessResult(Messages.NufusAdded);
        }
        private IResult CheckIletisimExist(Iletisim iletisim)
        {
            if (iletisim != null)
            {
                var data = _iletisimDal.GetAll();

                var filteredData = data.Where(d => d.Id == iletisim.Id).FirstOrDefault();

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