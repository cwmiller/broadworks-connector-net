using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCPEConfigGetFileServerListRequest14sp6. The table columns are:
    /// "Device Type", "File Repository Name", "Directory", "Extended File Repository Name".
    /// <see cref="SystemCPEConfigGetFileServerListRequest14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7133""}]")]
    public class SystemCPEConfigGetFileServerListResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _fileServerTable;

        [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7133")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileServerTable
        {
            get => _fileServerTable;
            set
            {
                FileServerTableSpecified = true;
                _fileServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool FileServerTableSpecified { get; set; }

    }
}
