using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksMobilityServiceAccessCodeGetListRequest.
    /// Contains a table with column headings: "Country Code", "Service Access Code", "Description".
    /// Replaced by SystemBroadWorksMobilityServiceAccessCodeGetListReponse21.
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20526""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceAccessCodeTable;

        [XmlElement(ElementName = "serviceAccessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20526")]
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
