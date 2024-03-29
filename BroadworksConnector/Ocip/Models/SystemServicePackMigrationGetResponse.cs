using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemServicePackMigrationGetRequest.
    /// The response contains the Service Pack Migration system level settings.
    /// <see cref="SystemServicePackMigrationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16389""}]")]
    public class SystemServicePackMigrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maxSimultaneousMigrationTasks;

        [XmlElement(ElementName = "maxSimultaneousMigrationTasks", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16389")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaxSimultaneousMigrationTasks
        {
            get => _maxSimultaneousMigrationTasks;
            set
            {
                MaxSimultaneousMigrationTasksSpecified = true;
                _maxSimultaneousMigrationTasks = value;
            }
        }

        [XmlIgnore]
        protected bool MaxSimultaneousMigrationTasksSpecified { get; set; }

    }
}
