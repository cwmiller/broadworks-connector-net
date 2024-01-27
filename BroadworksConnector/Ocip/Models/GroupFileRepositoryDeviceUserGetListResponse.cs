using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupFileRepositoryDeviceUserGetListRequest.
    /// Contains a table with column headings : "User Name","Allow Delete","Allow Get","Allow Put" in a row for each file repository service provider user.
    /// <see cref="GroupFileRepositoryDeviceUserGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5669""}]")]
    public class GroupFileRepositoryDeviceUserGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryUserTable;

        [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5669")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileRepositoryUserTable
        {
            get => _fileRepositoryUserTable;
            set
            {
                FileRepositoryUserTableSpecified = true;
                _fileRepositoryUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool FileRepositoryUserTableSpecified { get; set; }

    }
}
