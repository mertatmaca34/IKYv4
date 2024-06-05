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
    public class KullaniciManager : IKullaniciManager
    {
        readonly IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public IResult Add(Kullanici kullanici)
        {
            IResult result = BusinessRules.Run(CheckKullaniciExist(kullanici));

            if (result == null)
            {
                this.Update(kullanici);

                return new SuccessResult(Messages.KullaniciUpdated);
            }
            else if (result != null)
            {
                _kullaniciDal.Add(kullanici);

                return new SuccessResult(Messages.KullaniciAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(Kullanici kullanici)
        {
            IResult result = BusinessRules.Run(CheckKullaniciExist(kullanici));

            if (result == null)
            {
                _kullaniciDal.Delete(kullanici);

                return new SuccessResult(Messages.KullaniciDeleted);
            }

            return new ErrorDataResult<Kullanici>(Messages.InvalidDelete);
        }

        public IDataResult<List<Kullanici>> GetAll(Expression<Func<Kullanici, bool>> filter = null)
        {
            var data = _kullaniciDal.GetAll(filter);

            if (data.Count == 0)
            {
                return new ErrorDataResult<List<Kullanici>>(data);
            }
            else
            {
                return new SuccessDataResult<List<Kullanici>>(data);
            }
        }

        public IResult Update(Kullanici kullanici)
        {
            IResult result = BusinessRules.Run(CheckKullaniciExist(kullanici));

            if (result == null)
            {
                var existEntity = _kullaniciDal.GetAll().Where(c => c.Id == kullanici.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    kullanici.Id = existEntity.Id;

                    _kullaniciDal.Update(kullanici);

                    return new SuccessResult(Messages.KullaniciUpdated);
                }
            }

            this.Add(kullanici);

            return new SuccessResult(Messages.KullaniciAdded);
        }
        private IResult CheckKullaniciExist(Kullanici kullanici)
        {
            if (kullanici != null)
            {
                var data = _kullaniciDal.GetAll();

                var filteredData = data.Where(d => d.Id == kullanici.Id).FirstOrDefault();

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