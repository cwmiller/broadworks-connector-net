using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRoutePointExternalSystemGetListRequest.
    /// 
    /// Contains a table with column headings:
    /// "External System", "Description".
    /// <see cref="SystemRoutePointExternalSystemGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15139""}]")]
    public class SystemRoutePointExternalSystemGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _externalSystemTable;

        [XmlElement(ElementName = "externalSystemTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15139")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ExternalSystemTable
        {
            get => _externalSystemTable;
            set
            {
                ExternalSystemTableSpecified = true;
                _externalSystemTable = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalSystemTableSpecified { get; set; }

    }
}
