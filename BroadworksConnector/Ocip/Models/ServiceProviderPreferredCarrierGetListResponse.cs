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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:242""}]")]
    public class ServiceProviderPreferredCarrierGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderCarrierTable;

        [XmlElement(ElementName = "serviceProviderCarrierTable", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:242")]
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
