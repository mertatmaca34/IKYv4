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
    public class CalismaSaatleriManager : ICalismaSaatleriManager
    {
        readonly ICalismaSaatleriDal _calismaSaatleriDal;

        public CalismaSaatleriManager(ICalismaSaatleriDal calismaSaatleriDal)
        {
            _calismaSaatleriDal = calismaSaatleriDal;
        }

        public IResult Add(CalismaSaatleri calismaSaatleri)
        {
            IResult result = BusinessRules.Run(CheckCalismaSaatleriExist(calismaSaatleri));

            if (result == null)
            {
                this.Update(calismaSaatleri);

                return new SuccessResult(Messages.CalismaSaatleriUpdated);
            }
            else if (result != null)
            {
                _calismaSaatleriDal.Add(calismaSaatleri);

                return new SuccessResult(Messages.CalismaSaatleriAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(CalismaSaatleri calismaSaatleri)
        {
            IResult result = BusinessRules.Run(CheckCalismaSaatleriExist(calismaSaatleri));

            if (result == null)
            {
                _calismaSaatleriDal.Delete(calismaSaatleri);

                return new SuccessResult(Messages.CalismaSaatleriDeleted);
            }

            return new ErrorDataResult<CalismaSaatleri>(Messages.InvalidDelete);
        }

        public IDataResult<List<CalismaSaatleri>> GetAll(Expression<Func<CalismaSaatleri, bool>> filter = null)
        {
            return new SuccessDataResult<List<CalismaSaatleri>>(_calismaSaatleriDal.GetAll(filter));
        }

        public IResult Update(CalismaSaatleri calismaSaatleri)
        {
            IResult result = BusinessRules.Run(CheckCalismaSaatleriExist(calismaSaatleri));

            if (result == null)
            {
                var existEntity = _calismaSaatleriDal.GetAll().Where(c => c.Id == calismaSaatleri.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    calismaSaatleri.Id = existEntity.Id;

                    _calismaSaatleriDal.Update(calismaSaatleri);

                    return new SuccessResult(Messages.CalismaSaatleriUpdated);
                }
            }

            this.Add(calismaSaatleri);

            return new SuccessResult(Messages.CalismaSaatleriAdded);
        }
        private IResult CheckCalismaSaatleriExist(CalismaSaatleri calismaSaatleri)
        {
            if (calismaSaatleri != null)
            {
                var data = _calismaSaatleriDal.GetAll();

                var filteredData = data.Where(d => d.Id == calismaSaatleri.Id).FirstOrDefault();

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