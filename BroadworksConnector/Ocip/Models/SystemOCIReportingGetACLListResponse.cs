using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIReportingACLListGetRequest.
    /// Contains a table with one row per access control list entry.
    /// The table columns are "Net Address", "Description" and "Restrict Messages".
    /// <see cref="SystemOCIReportingACLListGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13741""}]")]
    public class SystemOCIReportingGetACLListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _ociReportingACLTable;

        [XmlElement(ElementName = "ociReportingACLTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13741")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OciReportingACLTable
        {
            get => _ociReportingACLTable;
            set
            {
                OciReportingACLTableSpecified = true;
                _ociReportingACLTable = value;
            }
        }

        [XmlIgnore]
        protected bool OciReportingACLTableSpecified { get; set; }

    }
}
