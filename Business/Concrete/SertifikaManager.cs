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
    public class SertifikaManager : ISertifikaManager
    {
        readonly ISertifikaDal _sertifikaDal;

        public SertifikaManager(ISertifikaDal sertifikaDal)
        {
            _sertifikaDal = sertifikaDal;
        }

        public IResult Add(Sertifika sertifika)
        {
            IResult result = BusinessRules.Run(CheckSertifikaExist(sertifika));

            if (result == null)
            {
                this.Update(sertifika);

                return new SuccessResult(Messages.CalismaSaatleriUpdated);
            }
            else if (result != null)
            {
                _sertifikaDal.Add(sertifika);

                return new SuccessResult(Messages.NufusAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Sertifika sertifika)
        {
            IResult result = BusinessRules.Run(CheckSertifikaExist(sertifika));

            if (result == null)
            {
                _sertifikaDal.Delete(sertifika);

                return new SuccessResult(Messages.CalismaSaatleriDeleted);
            }

            return new ErrorDataResult<Sertifika>(Messages.InvalidDelete);
        }

        public IDataResult<List<Sertifika>> GetAll(Expression<Func<Sertifika, bool>> filter = null)
        {
            return new SuccessDataResult<List<Sertifika>>(_sertifikaDal.GetAll(filter));
        }

        public IResult Update(Sertifika sertifika)
        {
            IResult result = BusinessRules.Run(CheckSertifikaExist(sertifika));

            if (result == null)
            {
                var existEntity = _sertifikaDal.GetAll().Where(c => c.Id == sertifika.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    sertifika.Id = existEntity.Id;

                    _sertifikaDal.Update(sertifika);

                    return new SuccessResult(Messages.CalismaSaatleriUpdated);
                }
            }

            this.Add(sertifika);

            return new SuccessResult(Messages.NufusAdded);
        }
        private IResult CheckSertifikaExist(Sertifika sertifika)
        {
            if (sertifika != null)
            {
                var data = _sertifikaDal.GetAll();

                var filteredData = data.Where(d => d.Id == sertifika.Id).FirstOrDefault();

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