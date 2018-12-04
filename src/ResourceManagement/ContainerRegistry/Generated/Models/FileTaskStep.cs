// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a task step.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FileTask")]
    public partial class FileTaskStep : TaskStepProperties
    {
        /// <summary>
        /// Initializes a new instance of the FileTaskStep class.
        /// </summary>
        public FileTaskStep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileTaskStep class.
        /// </summary>
        /// <param name="taskFilePath">The task template/definition file path
        /// relative to the source context.</param>
        /// <param name="baseImageDependencies">List of base image dependencies
        /// for a step.</param>
        /// <param name="contextPath">The URL(absolute or relative) of the
        /// source context for the task step.</param>
        /// <param name="contextAccessToken">The token (git PAT or SAS token of
        /// storage account blob) associated with the context for a
        /// step.</param>
        /// <param name="valuesFilePath">The task values/parameters file path
        /// relative to the source context.</param>
        /// <param name="values">The collection of overridable values that can
        /// be passed when running a task.</param>
        public FileTaskStep(string taskFilePath, IList<BaseImageDependency> baseImageDependencies = default(IList<BaseImageDependency>), string contextPath = default(string), string contextAccessToken = default(string), string valuesFilePath = default(string), IList<SetValue> values = default(IList<SetValue>))
            : base(baseImageDependencies, contextPath, contextAccessToken)
        {
            TaskFilePath = taskFilePath;
            ValuesFilePath = valuesFilePath;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the task template/definition file path relative to the
        /// source context.
        /// </summary>
        [JsonProperty(PropertyName = "taskFilePath")]
        public string TaskFilePath { get; set; }

        /// <summary>
        /// Gets or sets the task values/parameters file path relative to the
        /// source context.
        /// </summary>
        [JsonProperty(PropertyName = "valuesFilePath")]
        public string ValuesFilePath { get; set; }

        /// <summary>
        /// Gets or sets the collection of overridable values that can be
        /// passed when running a task.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<SetValue> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaskFilePath");
            }
            if (Values != null)
            {
                foreach (var element in Values)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
