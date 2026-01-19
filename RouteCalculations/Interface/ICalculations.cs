using System.Collections.Generic;
using System.Threading.Tasks;

namespace RouteCalculations.Interface
{
    public interface ICalculations
    {
        Task<IEnumerable<PTV_REST_API_VERSION_2.EmissionValues>> CalculateEmissionAsync(double pStartLongitude,
                                                                                        double pStartLatitude,
                                                                                        double pEndLongitude,
                                                                                        double pEndLatitude,
                                                                                        string pProfil);
    }
}
