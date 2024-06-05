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
    public class SeflikManager : ISeflikManager
    {
        readonly ISeflikDal _seflikDal;

        public SeflikManager(ISeflikDal seflikDal)
        {
            _seflikDal = seflikDal;
        }

        public IResult Add(Seflik seflik)
        {
            IResult result = BusinessRules.Run(CheckSeflikExist(seflik));

            if (result == null)
            {
                this.Update(seflik);

                return new SuccessResult(Messages.SeflikUpdated);
            }
            else if (result != null)
            {
                _seflikDal.Add(seflik);

                return new SuccessResult(Messages.SeflikAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Seflik seflik)
        {
            IResult result = BusinessRules.Run(CheckSeflikExist(seflik));

            if (result == null)
            {
                _seflikDal.Delete(seflik);

                return new SuccessResult(Messages.SeflikDeleted);
            }

            return new ErrorDataResult<Seflik>(Messages.InvalidDelete);
        }

        public IDataResult<List<Seflik>> GetAll(Expression<Func<Seflik, bool>> filter = null)
        {
            var data = _seflikDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<Seflik>>(data);
            }
            else
            {
                return new SuccessDataResult<List<Seflik>>(data);
            }
        }

        public IResult Update(Seflik seflik)
        {
            IResult result = BusinessRules.Run(CheckSeflikExist(seflik));

            if (result == null)
            {
                var existEntity = _seflikDal.GetAll().Where(c => c.Id == seflik.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    seflik.Id = existEntity.Id;

                    _seflikDal.Update(seflik);

                    return new SuccessResult(Messages.SeflikUpdated);
                }
            }

            this.Add(seflik);

            return new SuccessResult(Messages.SeflikAdded);
        }
        private IResult CheckSeflikExist(Seflik seflik)
        {
            if (seflik != null)
            {
                var data = _seflikDal.GetAll();

                var filteredData = data.Where(d => d.Id == seflik.Id).FirstOrDefault();

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