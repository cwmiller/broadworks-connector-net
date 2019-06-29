using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksMobilityServiceAccessCodeGetListRequest21.
    /// Contains a table with column headings: "Country Code", "Service Access Code", "Description"
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1089""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceAccessCodeTable;

        [XmlElement(ElementName = "serviceAccessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1089")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceAccessCodeTable
        {
            get => _serviceAccessCodeTable;
            set
            {
                ServiceAccessCodeTableSpecified = true;
                _serviceAccessCodeTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceAccessCodeTableSpecified { get; set; }

    }
}
