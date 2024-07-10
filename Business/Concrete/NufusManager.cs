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
    public class NufusManager : INufusManager
    {
        readonly INufusDal _nufusDal;

        public NufusManager(INufusDal nufusDal)
        {
            _nufusDal = nufusDal;
        }

        public IResult Add(Nufus nufus)
        {
            IResult result = BusinessRules.Run(CheckNufusExist(nufus));

            if (result == null)
            {
                this.Update(nufus);

                return new SuccessResult(Messages.NufusUpdated);
            }
            else if (result != null)
            {
                _nufusDal.Add(nufus);

                return new SuccessResult(Messages.NufusAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Nufus nufus)
        {
            IResult result = BusinessRules.Run(CheckNufusExist(nufus));

            if (result == null)
            {
                _nufusDal.Delete(nufus);

                return new SuccessResult(Messages.NufusDeleted);
            }

            return new ErrorDataResult<Nufus>(Messages.InvalidDelete);
        }

        public IDataResult<List<Nufus>> GetAll(Expression<Func<Nufus, bool>> filter = null)
        {
            return new SuccessDataResult<List<Nufus>>(_nufusDal.GetAll(filter));
        }

        public IResult Update(Nufus nufus)
        {
            IResult result = BusinessRules.Run(CheckNufusExist(nufus));

            if (result == null)
            {
                var existEntity = _nufusDal.GetAll().Where(c => c.Id == nufus.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    nufus.Id = existEntity.Id;

                    _nufusDal.Update(nufus);

                    return new SuccessResult(Messages.NufusUpdated);
                }
            }

            this.Add(nufus);

            return new SuccessResult(Messages.NufusAdded);
        }
        private IResult CheckNufusExist(Nufus nufus)
        {
            if (nufus != null)
            {
                var data = _nufusDal.GetAll();

                var filteredData = data.Where(d => d.Id == nufus.Id).FirstOrDefault();

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