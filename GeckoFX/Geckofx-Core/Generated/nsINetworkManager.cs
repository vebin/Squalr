// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsINetworkManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// Information about networks that is exposed to network manager API consumers.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cb62ae03-6bda-43ff-9560-916d60203d33")]
	public interface nsINetworkInterface
	{
		
		/// <summary>
        /// Current network state, one of the NETWORK_STATE_* constants.
        ///
        /// When this changes, network interface implementations notify the
        /// 'network-interface-state-changed' observer notification.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStateAttribute();
		
		/// <summary>
        /// Network type. One of the NETWORK_TYPE_* constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTypeAttribute();
		
		/// <summary>
        /// Name of the network interface. This identifier is unique.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		/// <summary>
        /// The host name of the http proxy server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHttpProxyHostAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpProxyHost);
		
		/// <summary>
        /// The port number of the http proxy server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetHttpProxyPortAttribute();
		
		/// <summary>
        /// Get the list of ip addresses and prefix lengths, ip address could be IPv4
        /// or IPv6, typically 1 IPv4 or 1 IPv6 or one of each.
        ///
        /// @param ips
        /// The list of ip addresses retrieved.
        /// @param prefixLengths
        /// The list of prefix lengths retrieved.
        ///
        /// @returns the length of the lists.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAddresses([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] ref System.IntPtr[] ips, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] ref uint[] prefixLengths);
		
		/// <summary>
        /// Get the list of gateways, could be IPv4 or IPv6, typically 1 IPv4 or 1
        /// IPv6 or one of each.
        ///
        /// @param count
        /// The length of the list of gateways
        ///
        /// @returns the list of gateways.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGateways(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] gateways);
		
		/// <summary>
        /// Get the list of dnses, could be IPv4 or IPv6.
        ///
        /// @param count
        /// The length of the list of dnses.
        ///
        /// @returns the list of dnses.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDnses(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] dnses);
	}
	
	/// <summary>nsINetworkInterfaceConsts </summary>
	public class nsINetworkInterfaceConsts
	{
		
		// <summary>
        // Information about networks that is exposed to network manager API consumers.
        // </summary>
		public const long NETWORK_STATE_UNKNOWN = -1;
		
		// 
		public const long NETWORK_STATE_CONNECTING = 0;
		
		// 
		public const long NETWORK_STATE_CONNECTED = 1;
		
		// 
		public const long NETWORK_STATE_DISCONNECTING = 2;
		
		// 
		public const long NETWORK_STATE_DISCONNECTED = 3;
		
		// 
		public const long NETWORK_TYPE_UNKNOWN = -1;
		
		// 
		public const long NETWORK_TYPE_WIFI = 0;
		
		// 
		public const long NETWORK_TYPE_MOBILE = 1;
		
		// 
		public const long NETWORK_TYPE_MOBILE_MMS = 2;
		
		// 
		public const long NETWORK_TYPE_MOBILE_SUPL = 3;
		
		// 
		public const long NETWORK_TYPE_WIFI_P2P = 4;
		
		// 
		public const long NETWORK_TYPE_MOBILE_IMS = 5;
		
		// 
		public const long NETWORK_TYPE_MOBILE_DUN = 6;
	}
	
	/// <summary>
    /// Manage network interfaces.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3ea50550-4b3c-11e3-8f96-0800200c9a66")]
	public interface nsINetworkManager
	{
		
		/// <summary>
        /// Register the given network interface with the network manager.
        ///
        /// Consumers will be notified with the 'network-interface-registered'
        /// observer notification.
        ///
        /// Throws if there's already an interface registered that has the same
        /// name.
        ///
        /// @param network
        /// Network interface to register.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterNetworkInterface([MarshalAs(UnmanagedType.Interface)] nsINetworkInterface network);
		
		/// <summary>
        /// Unregister the given network interface from the network manager.
        ///
        /// Consumers will be notified with the 'network-interface-unregistered'
        /// observer notification.
        ///
        /// Throws an exception if the specified network interface object isn't
        /// registered.
        ///
        /// @param network
        /// Network interface to unregister.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterNetworkInterface([MarshalAs(UnmanagedType.Interface)] nsINetworkInterface network);
		
		/// <summary>
        /// Object containing all known network connections, keyed by their
        /// interface name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetNetworkInterfacesAttribute();
		
		/// <summary>
        /// The preferred network type. One of the
        /// nsINetworkInterface::NETWORK_TYPE_* constants.
        ///
        /// This attribute is used for setting default route to favor
        /// interfaces with given type.  This can be overriden by calling
        /// overrideDefaultRoute().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPreferredNetworkTypeAttribute();
		
		/// <summary>
        /// The preferred network type. One of the
        /// nsINetworkInterface::NETWORK_TYPE_* constants.
        ///
        /// This attribute is used for setting default route to favor
        /// interfaces with given type.  This can be overriden by calling
        /// overrideDefaultRoute().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPreferredNetworkTypeAttribute(int aPreferredNetworkType);
		
		/// <summary>
        /// The network interface handling all data traffic.
        ///
        /// When this changes, the 'network-active-changed' observer
        /// notification is dispatched.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsINetworkInterface GetActiveAttribute();
		
		/// <summary>
        /// Override the default behaviour for preferredNetworkType and route
        /// all network traffic through the the specified interface.
        ///
        /// Consumers can observe changes to the active network by subscribing to
        /// the 'network-active-changed' observer notification.
        ///
        /// @param network
        /// Network to route all network traffic to. If this is null,
        /// a previous override is canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int OverrideActive([MarshalAs(UnmanagedType.Interface)] nsINetworkInterface network);
		
		/// <summary>
        /// Enable or disable Wifi Tethering
        ///
        /// @param enabled
        /// Boolean that indicates whether tethering should be enabled (true) or disabled (false).
        /// @param network
        /// The Wifi network interface with at least name of network interface.
        /// @param config
        /// The Wifi Tethering configuration from settings db.
        /// @param callback
        /// Callback function used to report status to WifiManager.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWifiTethering([MarshalAs(UnmanagedType.U1)] bool enabled, [MarshalAs(UnmanagedType.Interface)] nsINetworkInterface networkInterface, ref Gecko.JsVal config, [MarshalAs(UnmanagedType.Interface)] nsIWifiTetheringCallback callback);
	}
}