using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The application Id advertised for billing (Ro or Rf) during the Diameter Capability Exchange.
    /// When base is selected, Acct-Application-Id=3 is advertised for offline billing and Auth-Application-Id=4 for online billing.
    /// When 3gpp is selected, Vendor-Specific-Application-Id(Acct-Application-Id=3; Vendor-Id=10415) is advertised for offline billing and Vendor-Specific-Application-Id(Auth-Application-Id=4; Vendor-Id=10415) for online billing.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BwDiameterAdvertisedApplication
    {
        [XmlEnum(Name = "Base")]
        Base,
        [XmlEnum(Name = "3gpp")]
        _3gpp,
    }
}
