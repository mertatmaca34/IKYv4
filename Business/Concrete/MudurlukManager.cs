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
    public class MudurlukManager : IMudurlukManager
    {
        readonly IMudurlukDal _mudurlukDal;

        public MudurlukManager(IMudurlukDal mudurlukDal)
        {
            _mudurlukDal = mudurlukDal;
        }

        public IResult Add(Mudurluk mudurluk)
        {
            IResult result = BusinessRules.Run(CheckMudurlukExist(mudurluk));

            if (result == null)
            {
                this.Update(mudurluk);

                return new SuccessResult(Messages.MudurlukUpdated);
            }
            else if (result != null)
            {
                _mudurlukDal.Add(mudurluk);

                return new SuccessResult(Messages.MudurlukAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Mudurluk mudurluk)
        {
            IResult result = BusinessRules.Run(CheckMudurlukExist(mudurluk));

            if (result == null)
            {
                _mudurlukDal.Delete(mudurluk);

                return new SuccessResult(Messages.MudurlukDeleted);
            }

            return new ErrorDataResult<Mudurluk>(Messages.InvalidDelete);
        }

        public IDataResult<List<Mudurluk>> GetAll(Expression<Func<Mudurluk, bool>> filter = null)
        {
            var data = _mudurlukDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<Mudurluk>>(data);
            }
            else
            {
                return new SuccessDataResult<List<Mudurluk>>(data);
            }
        }

        public IResult Update(Mudurluk mudurluk)
        {
            IResult result = BusinessRules.Run(CheckMudurlukExist(mudurluk));

            if (result == null)
            {
                var existEntity = _mudurlukDal.GetAll().Where(c => c.Id == mudurluk.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    mudurluk.Id = existEntity.Id;

                    _mudurlukDal.Update(mudurluk);

                    return new SuccessResult(Messages.MudurlukUpdated);
                }
            }

            this.Add(mudurluk);

            return new SuccessResult(Messages.MudurlukAdded);
        }
        private IResult CheckMudurlukExist(Mudurluk mudurluk)
        {
            if (mudurluk != null)
            {
                var data = _mudurlukDal.GetAll();

                var filteredData = data.Where(d => d.Id == mudurluk.Id).FirstOrDefault();

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