﻿namespace Ana.Source.Project.ProjectItems
{
    using Engine.Input.HotKeys;
    using System;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines a hotkey for a project item.
    /// </summary>
    [KnownType(typeof(Hotkey))]
    [DataContract]
    internal class ProjectItemHotkey : INotifyPropertyChanged
    {
        /// <summary>
        /// The target guid, from which the target project is derived.
        /// </summary>
        private Guid projectItemGuid;

        /// <summary>
        /// The hotkey bound to the project item.
        /// </summary>
        private Hotkey hotkey;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectItemHotkey" /> class.
        /// </summary>
        /// <param name="hotkey">The initial hotkey bound to the project item.</param>
        public ProjectItemHotkey(Hotkey hotkey, Guid projectItemGuid)
        {
            this.ProjectItemGuid = projectItemGuid;
            this.Hotkey = hotkey;
        }

        /// <summary>
        /// Occurs after a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the target project item guid.
        /// </summary>
        [DataMember]
        public Guid ProjectItemGuid
        {
            get
            {
                return this.projectItemGuid;
            }

            set
            {
                this.projectItemGuid = value;
                this.NotifyPropertyChanged(nameof(this.ProjectItemGuid));
            }
        }

        /// <summary>
        /// Gets or sets the hotkey bound to the project item.
        /// </summary>
        [DataMember]
        public Hotkey Hotkey
        {
            get
            {
                return this.hotkey;
            }

            set
            {
                this.hotkey = value;
                this.NotifyPropertyChanged(nameof(this.Hotkey));
            }
        }

        /// <summary>
        /// Indicates that a given property in this project item has changed.
        /// </summary>
        /// <param name="propertyName">The name of the changed property.</param>
        protected void NotifyPropertyChanged(String propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    //// End class
}
//// End namespace