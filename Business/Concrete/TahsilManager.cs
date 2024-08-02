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
    public class TahsilManager : ITahsilManager
    {
        readonly ITahsilDal _tahsilDal;

        public TahsilManager(ITahsilDal tahsilDal)
        {
            _tahsilDal = tahsilDal;
        }

        public IResult Add(Tahsil tahsil)
        {
            IResult result = BusinessRules.Run(CheckTahsilExist(tahsil));

            if (result == null)
            {
                this.Update(tahsil);

                return new SuccessResult(Messages.TahsilUpdated);
            }
            else if (result != null)
            {
                _tahsilDal.Add(tahsil);

                return new SuccessResult(Messages.TahsilAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Tahsil tahsil)
        {
            IResult result = BusinessRules.Run(CheckTahsilExist(tahsil));

            if (result == null)
            {
                _tahsilDal.Delete(tahsil);

                return new SuccessResult(Messages.TahsilDeleted);
            }

            return new ErrorDataResult<Tahsil>(Messages.InvalidDelete);
        }

        public IDataResult<List<Tahsil>> GetAll(Expression<Func<Tahsil, bool>> filter = null)
        {
            return new SuccessDataResult<List<Tahsil>>(_tahsilDal.GetAll(filter));
        }

        public IResult Update(Tahsil tahsil)
        {
            IResult result = BusinessRules.Run(CheckTahsilExist(tahsil));

            if (result == null)
            {
                var existEntity = _tahsilDal.GetAll().Where(c => c.Id == tahsil.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    tahsil.Id = existEntity.Id;

                    _tahsilDal.Update(tahsil);

                    return new SuccessResult(Messages.TahsilUpdated);
                }
            }

            this.Add(tahsil);

            return new SuccessResult(Messages.TahsilAdded);
        }
        private IResult CheckTahsilExist(Tahsil tahsil)
        {
            if (tahsil != null)
            {
                var data = _tahsilDal.GetAll();

                var filteredData = data.Where(d => d.Id == tahsil.Id).FirstOrDefault();

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