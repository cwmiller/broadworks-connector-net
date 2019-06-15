using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system level settings for Service Pack Migration.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemServicePackMigrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _maxSimultaneousMigrationTasks;

        [XmlElement(ElementName = "maxSimultaneousMigrationTasks", IsNullable = false, Namespace = "")]
        public int MaxSimultaneousMigrationTasks {
            get => _maxSimultaneousMigrationTasks;
            set {
                MaxSimultaneousMigrationTasksSpecified = true;
                _maxSimultaneousMigrationTasks = value;
            }
        }

        [XmlIgnore]
        public bool MaxSimultaneousMigrationTasksSpecified { get; set; }
        
    }
}
