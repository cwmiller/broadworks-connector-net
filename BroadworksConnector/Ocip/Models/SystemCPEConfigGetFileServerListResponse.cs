using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCPEConfigGetFileServerListRequest. The table columns are:
    /// "Device Type", "FTP Host Net Address", "FTP User Id", "Directory" and "Passive FTP".
    /// Replaced By: SystemCPEConfigGetFileServerListResponse14sp6
    /// <see cref="SystemCPEConfigGetFileServerListRequest"/>
    /// <see cref="SystemCPEConfigGetFileServerListResponse14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:25384""}]")]
    public class SystemCPEConfigGetFileServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _fileServerTable;

        [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25384")]
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
