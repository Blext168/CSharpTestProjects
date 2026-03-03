using lit.map.ptv.api;
using RouteCalculations.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteCalculationsService.Service
{
    public class PtvCalculationsService : ICalculations
    {
        public async Task<IEnumerable<PTV_REST_API_VERSION_2.EmissionValues>> CalculateEmissionAsync(double pStartLongitude, 
                                                                                                     double pStartLatitude, 
                                                                                                     double pEndLongitude, 
                                                                                                     double pEndLatitude, 
                                                                                                     string pProfil)
        {
            // Prepare waypoints
            PTV_REST_API_VERSION_2.Coordinate startCoords = new PTV_REST_API_VERSION_2.Coordinate()
            {
                X = pStartLongitude,
                Y = pStartLatitude
            };

            PTV_REST_API_VERSION_2.Coordinate endCoords = new PTV_REST_API_VERSION_2.Coordinate()
            {
                X = pEndLongitude,
                Y = pEndLatitude
            };

            List<PTV_REST_API_VERSION_2.Coordinate> waypoints = new List<PTV_REST_API_VERSION_2.Coordinate>()
            {
                startCoords,
                endCoords
            };

            // Calcualte emissions
            PTV_REST_API_VERSION_2.RouteRequest request = CreateRouteRequest(pProfil, RouteCalculation.GetListOfWaypoints(waypoints), null);
            PTV_REST_API_VERSION_2.RouteResponse response = await PTV_2_INSTANCE.Instance.CalculateRouteAsync(request);

            return response.Emissions.Values.Where(w => w is PTV_REST_API_VERSION_2.EmissionValues_ISO14083_2023).ToList();
        }

        private PTV_REST_API_VERSION_2.RouteRequest CreateRouteRequest(string pProfile, List<PTV_REST_API_VERSION_2.InputWaypoint> pWaypoints, DateTime? pStartTime)
        {
            PTV_REST_API_VERSION_2.RouteRequest routeRequest = new PTV_REST_API_VERSION_2.RouteRequest
            {
                ResultFields = new PTV_REST_API_VERSION_2.RoutingResultFields
                {
                    Polyline = true,
                    Toll = new PTV_REST_API_VERSION_2.TollResultFields
                    {
                        Enabled = true,
                        Sections = true,
                        Systems = true
                    },
                    Emissions = true,
                    GuidedNavigationRoute = true,
                    EventTypes = new List<PTV_REST_API_VERSION_2.RouteEventType>
                {
                    PTV_REST_API_VERSION_2.RouteEventType.MANEUVER_EVENT,
                    PTV_REST_API_VERSION_2.RouteEventType.WAYPOINT_EVENT,
                    PTV_REST_API_VERSION_2.RouteEventType.COUNTRY_EVENT
                },
                    AlternativeRoutes = false,
                    EncodedPath = true
                },
                StoredProfile = pProfile,
                Waypoints = pWaypoints,
                RouteOptions = new PTV_REST_API_VERSION_2.RouteOptions
                {
                    Currency = "EUR",
                    CalculationCriteria = PTV_REST_API_VERSION_2.RouteCalculationCriteria.ABSTRACT_COSTS,
                    TollOptions = new PTV_REST_API_VERSION_2.TollOptions
                    {
                        ReturnZeroCosts = false
                    },
                    EmissionOptions = new PTV_REST_API_VERSION_2.EmissionOptions
                    {
                        ValueScenarios = new List<PTV_REST_API_VERSION_2.EmissionValueScenario>()
                        {
                            new PTV_REST_API_VERSION_2.EmissionValueScenario_ISO14083_2023()
                            {
                              Scenarios = new List<PTV_REST_API_VERSION_2.EmissionValueScenarioType_ISO14083_2023>()
                              {
                                  PTV_REST_API_VERSION_2.EmissionValueScenarioType_ISO14083_2023.VEHICLE_SPECIFIC_AVERAGE_CONSUMPTION,
                              }
                            }
                        },
                    },
                },
                RequestProfile = new PTV_REST_API_VERSION_2.RequestProfile
                {
                    FeatureLayerProfile = new PTV_REST_API_VERSION_2.FeatureLayerProfile
                    {
                        Themes = new List<PTV_REST_API_VERSION_2.Theme>
                    {
                        new PTV_REST_API_VERSION_2.Theme
                        {
                            Id = "PTV_TruckAttributes",
                            Enabled = true
                        },
                        new PTV_REST_API_VERSION_2.Theme
                        {
                            Id = "PTV_RestrictionZones",
                            Enabled = true
                        }
                    }
                    },
                    UserLanguage = "de"
                }
            };
            if (pStartTime.HasValue && pStartTime != DateTime.MinValue)
            {
                routeRequest.RouteOptions.TimeConsideration = new PTV_REST_API_VERSION_2.ExactTimeConsiderationAtStart
                {
                    ReferenceTime = pStartTime
                };
            }

            return routeRequest;
        }

    }
}
