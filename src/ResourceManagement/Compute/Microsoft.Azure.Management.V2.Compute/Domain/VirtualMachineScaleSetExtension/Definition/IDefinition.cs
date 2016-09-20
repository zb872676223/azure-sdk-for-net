/**
* Copyright (c) Microsoft Corporation. All rights reserved.
* Licensed under the MIT License. See License.txt in the project root for
* license information.
*/ 

namespace Microsoft.Azure.Management.V2.Compute.VirtualMachineScaleSetExtension.Definition
{

    using Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.V2.Compute;
    using System.Collections.Generic;

    /// <summary>
    /// The first stage of a virtual machine scale set extension definition.
    /// 
    /// @param <ParentT> the return type of the final {@link WithAttach#attach()}
    /// </summary>
    public interface IBlank<ParentT>  :
        IWithImageOrPublisher<ParentT>
    {
    }
    /// <summary>
    /// The entirety of a virtual machine scale set extension definition as a part of parent definition.
    /// 
    /// @param <ParentT> the return type of the final {@link Attachable#attach()}
    /// </summary>
    public interface IDefinition<ParentT>  :
        IBlank<ParentT>,
        IWithImageOrPublisher<ParentT>,
        IWithPublisher<ParentT>,
        IWithType<ParentT>,
        IWithVersion<ParentT>,
        IWithAttach<ParentT>
    {
    }
    /// <summary>
    /// The final stage of the virtual machine scale set extension definition.
    /// <p>
    /// At this stage, any remaining optional settings can be specified, or the virtual machine scale set extension definition
    /// can be attached to the parent virtual machine scale set definition using {@link VirtualMachineExtension.DefinitionStages.WithAttach#attach()}.
    /// @param <ParentT> the return type of {@link VirtualMachineExtension.DefinitionStages.WithAttach#attach()}
    /// </summary>
    public interface IWithAttach<ParentT>  :
        IInDefinition<ParentT>,
        IWithAutoUpgradeMinorVersion<ParentT>,
        IWithSettings<ParentT>
    {
    }
    /// <summary>
    /// The stage of the virtual machinescale set extension definition allowing to specify extension image or specify name of
    /// the virtual machine scale set extension publisher.
    /// 
    /// @param <ParentT> the return type of {@link WithAttach#attach()}
    /// </summary>
    public interface IWithImageOrPublisher<ParentT>  :
        IWithPublisher<ParentT>
    {
        //
        /// <summary>
        /// Specifies the virtual machine scale set extension image to use.
        /// </summary>
        /// <param name="image">image the image</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithImage (IVirtualMachineExtensionImage image);
    }

    /// <summary>
    /// The stage of the virtual machine scale set extension definition allowing to specify the type of the virtual machine
    /// scale set extension version this extension is based on.
    /// 
    /// @param <ParentT> the return type of {@link WithAttach#attach()}
    /// </summary>
    public interface IWithVersion<ParentT> 
    {
        /// <summary>
        /// Specifies the version of the virtual machine scale set image extension.
        /// </summary>
        /// <param name="extensionImageVersionName">extensionImageVersionName the version name</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithVersion (string extensionImageVersionName);

    }
    /// <summary>
    /// The stage of the virtual machine scale set extension definition allowing to specify the type of the virtual machine
    /// scale set extension image this extension is based on.
    /// 
    /// @param <ParentT> the return type of {@link WithAttach#attach()}
    /// </summary>
    public interface IWithType<ParentT> 
    {
        /// <summary>
        /// Specifies the type of the virtual machine scale set extension image.
        /// </summary>
        /// <param name="extensionImageTypeName">extensionImageTypeName the image type name</param>
        /// <returns>the next stage of the definition</returns>
        IWithVersion<ParentT> WithType (string extensionImageTypeName);

    }
    /// <summary>
    /// The stage of the virtual machine scale set extension definition allowing to specify the publisher of the
    /// virtual machine scale set extension image this extension is based on.
    /// 
    /// @param <ParentT> the return type of {@link WithAttach#attach()}
    /// </summary>
    public interface IWithPublisher<ParentT> 
    {
        /// <summary>
        /// Specifies the name of the virtual machine scale set extension image publisher.
        /// </summary>
        /// <param name="extensionImagePublisherName">extensionImagePublisherName the publisher name</param>
        /// <returns>the next stage of the definition</returns>
        IWithType<ParentT> WithPublisher (string extensionImagePublisherName);

    }
    /// <summary>
    /// The stage of the virtual machine scale set extension definition allowing to enable or disable auto upgrade of the
    /// extension when when a new minor version of virtual machine scale set extension image gets published.
    /// 
    /// @param <ParentT> the return type of {@link WithAttach#attach()}
    /// </summary>
    public interface IWithAutoUpgradeMinorVersion<ParentT> 
    {
        /// <summary>
        /// enables auto upgrade of the extension.
        /// </summary>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithAutoUpgradeMinorVersionEnabled ();

        /// <summary>
        /// disables auto upgrade of the extension.
        /// </summary>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithAutoUpgradeMinorVersionDisabled ();

    }
    /// <summary>
    /// The stage of the virtual machine scale set extension definition allowing to specify the public and private settings.
    /// 
    /// @param <ParentT> the return type of {@link WithAttach#attach()}
    /// </summary>
    public interface IWithSettings<ParentT> 
    {
        /// <summary>
        /// Specifies a public settings entry.
        /// </summary>
        /// <param name="key">key the key of a public settings entry</param>
        /// <param name="value">value the value of the public settings entry</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithPublicSetting (string key, object value);

        /// <summary>
        /// Specifies a private settings entry.
        /// </summary>
        /// <param name="key">key the key of a private settings entry</param>
        /// <param name="value">value the value of the private settings entry</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithProtectedSetting (string key, object value);

        /// <summary>
        /// Specifies public settings.
        /// </summary>
        /// <param name="settings">settings the public settings</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithPublicSettings (IDictionary<string,object> settings);

        /// <summary>
        /// Specifies private settings.
        /// </summary>
        /// <param name="settings">settings the private settings</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithProtectedSettings (IDictionary<string,object> settings);

    }
}