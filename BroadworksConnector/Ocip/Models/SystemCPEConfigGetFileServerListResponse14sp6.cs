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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6680""}]")]
    public class SystemCPEConfigGetFileServerListResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _fileServerTable;

        [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6680")]
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
