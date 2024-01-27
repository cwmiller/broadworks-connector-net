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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21260""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceAccessCodeTable;

        [XmlElement(ElementName = "serviceAccessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21260")]
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
