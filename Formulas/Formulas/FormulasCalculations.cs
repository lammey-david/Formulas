using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulas
{
    public class FormulasCalculations
    {
        private readonly FormulasRepository _repository;

        public FormulasCalculations(FormulasRepository repo)
        {
            _repository = repo;
        }

        public IEnumerable<Formulas> GetTotal(double amt)
        {
            return _repository.GetTotal().Where(formulas => formulas.Total == amt);
        }
    }
}
