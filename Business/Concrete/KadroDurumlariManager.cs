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
    public class KadroDurumlariManager : IKadroDurumlariManager
    {
        readonly IKadroDurumlariDal _kadroDurumlariDal;

        public KadroDurumlariManager(IKadroDurumlariDal kadroDurumlariDal)
        {
            _kadroDurumlariDal = kadroDurumlariDal;
        }

        public IResult Add(KadroDurumlari kadroDurumlari)
        {
            IResult result = BusinessRules.Run(CheckKadroDurumlariExist(kadroDurumlari));

            if (result == null)
            {
                this.Update(kadroDurumlari);

                return new SuccessResult(Messages.KadroDurumlariUpdated);
            }
            else if (result != null)
            {
                _kadroDurumlariDal.Add(kadroDurumlari);

                return new SuccessResult(Messages.KadroDurumlariAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(KadroDurumlari kadroDurumlari)
        {
            IResult result = BusinessRules.Run(CheckKadroDurumlariExist(kadroDurumlari));

            if (result == null)
            {
                _kadroDurumlariDal.Delete(kadroDurumlari);

                return new SuccessResult(Messages.KadroDurumlariDeleted);
            }

            return new ErrorDataResult<KadroDurumlari>(Messages.InvalidDelete);
        }

        public IDataResult<List<KadroDurumlari>> GetAll(Expression<Func<KadroDurumlari, bool>> filter = null)
        {
            return new SuccessDataResult<List<KadroDurumlari>>(_kadroDurumlariDal.GetAll(filter));
        }

        public IResult Update(KadroDurumlari kadroDurumlari)
        {
            IResult result = BusinessRules.Run(CheckKadroDurumlariExist(kadroDurumlari));

            if (result == null)
            {
                var existEntity = _kadroDurumlariDal.GetAll().Where(c => c.Id == kadroDurumlari.Id).FirstOrDefault();

                if (existEntity != null)
                {
                    kadroDurumlari.Id = existEntity.Id;

                    _kadroDurumlariDal.Update(kadroDurumlari);

                    return new SuccessResult(Messages.KadroDurumlariUpdated);
                }
            }

            this.Add(kadroDurumlari);

            return new SuccessResult(Messages.KadroDurumlariAdded);
        }
        private IResult CheckKadroDurumlariExist(KadroDurumlari kadroDurumlari)
        {
            if (kadroDurumlari != null)
            {
                var data = _kadroDurumlariDal.GetAll();

                var filteredData = data.Where(d => d.Id == kadroDurumlari.Id).FirstOrDefault();

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