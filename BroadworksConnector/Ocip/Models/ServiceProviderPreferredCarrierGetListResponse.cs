using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a ServiceProviderPreferredCarrierGetListRequest. Contains a table with one row per carrier.
    /// The table columns are: "Country Code", "Intra-Lata PIC", "Inter-Lata PIC", "International PIC".
    /// <see cref="ServiceProviderPreferredCarrierGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:241""}]")]
    public class ServiceProviderPreferredCarrierGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderCarrierTable;

        [XmlElement(ElementName = "serviceProviderCarrierTable", IsNullable = false, Namespace = "")]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:241")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderCarrierTable
        {
            get => _serviceProviderCarrierTable;
            set
            {
                ServiceProviderCarrierTableSpecified = true;
                _serviceProviderCarrierTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderCarrierTableSpecified { get; set; }

    }
}
