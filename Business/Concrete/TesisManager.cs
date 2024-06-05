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
    public class TesisManager : ITesisManager
    {
        readonly ITesisDal _tesisDal;

        public TesisManager(ITesisDal tesisDal)
        {
            _tesisDal = tesisDal;
        }

        public IResult Add(Tesis tesis)
        {
            IResult result = BusinessRules.Run(CheckTesisExist(tesis));

            if (result == null)
            {
                this.Update(tesis);

                return new SuccessResult(Messages.TesisUpdated);
            }
            else if (result != null)
            {
                _tesisDal.Add(tesis);

                return new SuccessResult(Messages.TesisAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Tesis tesis)
        {
            IResult result = BusinessRules.Run(CheckTesisExist(tesis));

            if (result == null)
            {
                _tesisDal.Delete(tesis);

                return new SuccessResult(Messages.TesisDeleted);
            }

            return new ErrorDataResult<Tesis>(Messages.InvalidDelete);
        }

        public IDataResult<List<Tesis>> GetAll(Expression<Func<Tesis, bool>> filter = null)
        {
            var data = _tesisDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<Tesis>>(data);
            }
            else
            {
                return new SuccessDataResult<List<Tesis>>(data);
            }
        }

        public IResult Update(Tesis tesis)
        {
            IResult result = BusinessRules.Run(CheckTesisExist(tesis));

            if (result == null)
            {
                var existEntity = _tesisDal.GetAll().Where(c => c.Id == tesis.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    tesis.Id = existEntity.Id;

                    _tesisDal.Update(tesis);

                    return new SuccessResult(Messages.TesisUpdated);
                }
            }

            this.Add(tesis);

            return new SuccessResult(Messages.TesisAdded);
        }
        private IResult CheckTesisExist(Tesis tesis)
        {
            if (tesis != null)
            {
                var data = _tesisDal.GetAll();

                var filteredData = data.Where(d => d.Id == tesis.Id).FirstOrDefault();

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