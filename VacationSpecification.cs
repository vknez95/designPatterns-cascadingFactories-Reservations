using System.Collections.Generic;

namespace Reservations
{
    public class VacationSpecification
    {
        private IList<IVacationPart> parts;

        public VacationSpecification(IList<IVacationPart> parts)
        {
            this.parts = parts;
        }
    }
}