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
    public class NakilManager : INakilManager
    {
        readonly INakilDal _nakilDal;

        public NakilManager(INakilDal nakilDal)
        {
            _nakilDal = nakilDal;
        }

        public IResult Add(Nakil nakil)
        {
            IResult result = BusinessRules.Run(CheckNakilExist(nakil));

            if (result == null)
            {
                this.Update(nakil);

                return new SuccessResult(Messages.NakilUpdated);
            }
            else if (result != null)
            {
                _nakilDal.Add(nakil);

                return new SuccessResult(Messages.NakilAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Nakil nakil)
        {
            IResult result = BusinessRules.Run(CheckNakilExist(nakil));

            if (result == null)
            {
                _nakilDal.Delete(nakil);

                return new SuccessResult(Messages.NakilDeleted);
            }

            return new ErrorDataResult<Nakil>(Messages.InvalidDelete);
        }

        public IDataResult<List<Nakil>> GetAll(Expression<Func<Nakil, bool>> filter = null)
        {
            return new SuccessDataResult<List<Nakil>>(_nakilDal.GetAll(filter));
        }

        public IResult Update(Nakil nakil)
        {
            IResult result = BusinessRules.Run(CheckNakilExist(nakil));

            if (result == null)
            {
                var existEntity = _nakilDal.GetAll().Where(c => c.Id == nakil.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    nakil.Id = existEntity.Id;

                    _nakilDal.Update(nakil);

                    return new SuccessResult(Messages.NakilUpdated);
                }
            }

            this.Add(nakil);

            return new SuccessResult(Messages.NufusAdded);
        }
        private IResult CheckNakilExist(Nakil nakil)
        {
            if (nakil != null)
            {
                var data = _nakilDal.GetAll();

                var filteredData = data.Where(d => d.Id == nakil.Id).FirstOrDefault();

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