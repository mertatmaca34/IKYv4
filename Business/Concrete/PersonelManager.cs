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
    public class PersonelManager : IPersonelManager
    {
        readonly IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IResult Add(Personel personel)
        {
            IResult result = BusinessRules.Run(CheckPersonelExist(personel));

            if (result == null)
            {
                this.Update(personel);

                return new SuccessResult(Messages.PersonelUpdated);
            }
            else if (result != null)
            {
                _personelDal.Add(personel);

                return new SuccessResult(Messages.PersonelAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Personel personel)
        {
            IResult result = BusinessRules.Run(CheckPersonelExist(personel));

            if (result == null)
            {
                _personelDal.Delete(personel);

                return new SuccessResult(Messages.PersonelDeleted);
            }

            return new ErrorDataResult<Personel>(Messages.InvalidDelete);
        }

        public IDataResult<List<Personel>> GetAll(Expression<Func<Personel, bool>> filter = null)
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(filter));
        }

        public IResult Update(Personel personel)
        {
            IResult result = BusinessRules.Run(CheckPersonelExist(personel));

            if (result == null)
            {
                var existEntity = _personelDal.GetAll().Where(c => c.Id == personel.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    personel.Id = existEntity.Id;

                    _personelDal.Update(personel);

                    return new SuccessResult(Messages.PersonelUpdated);
                }
            }

            this.Add(personel);

            return new SuccessResult(Messages.PersonelAdded);
        }
        private IResult CheckPersonelExist(Personel personel)
        {
            if (personel != null)
            {
                var data = _personelDal.GetAll();

                var filteredData = data.Where(d => d.Id == personel.Id).FirstOrDefault();

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