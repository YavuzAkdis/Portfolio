using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    internal class SkillService : ISkillService
    {
        ISkillDal _skillDal;

        public SkillService(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Update(t);
        }

        public Skill TGetById(int id)
        {
           return _skillDal.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
