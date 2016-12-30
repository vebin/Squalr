// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    internal class CfxBrowserCanGoBackRemoteCall : RemoteCall {

        internal CfxBrowserCanGoBackRemoteCall()
            : base(RemoteCallId.CfxBrowserCanGoBackRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_can_go_back(@this);
        }
    }

    internal class CfxBrowserGoBackRemoteCall : RemoteCall {

        internal CfxBrowserGoBackRemoteCall()
            : base(RemoteCallId.CfxBrowserGoBackRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_go_back(@this);
        }
    }

    internal class CfxBrowserCanGoForwardRemoteCall : RemoteCall {

        internal CfxBrowserCanGoForwardRemoteCall()
            : base(RemoteCallId.CfxBrowserCanGoForwardRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_can_go_forward(@this);
        }
    }

    internal class CfxBrowserGoForwardRemoteCall : RemoteCall {

        internal CfxBrowserGoForwardRemoteCall()
            : base(RemoteCallId.CfxBrowserGoForwardRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_go_forward(@this);
        }
    }

    internal class CfxBrowserIsLoadingRemoteCall : RemoteCall {

        internal CfxBrowserIsLoadingRemoteCall()
            : base(RemoteCallId.CfxBrowserIsLoadingRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_is_loading(@this);
        }
    }

    internal class CfxBrowserReloadRemoteCall : RemoteCall {

        internal CfxBrowserReloadRemoteCall()
            : base(RemoteCallId.CfxBrowserReloadRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_reload(@this);
        }
    }

    internal class CfxBrowserReloadIgnoreCacheRemoteCall : RemoteCall {

        internal CfxBrowserReloadIgnoreCacheRemoteCall()
            : base(RemoteCallId.CfxBrowserReloadIgnoreCacheRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_reload_ignore_cache(@this);
        }
    }

    internal class CfxBrowserStopLoadRemoteCall : RemoteCall {

        internal CfxBrowserStopLoadRemoteCall()
            : base(RemoteCallId.CfxBrowserStopLoadRemoteCall) {}

        internal IntPtr @this;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxApi.Browser.cfx_browser_stop_load(@this);
        }
    }

    internal class CfxBrowserGetIdentifierRemoteCall : RemoteCall {

        internal CfxBrowserGetIdentifierRemoteCall()
            : base(RemoteCallId.CfxBrowserGetIdentifierRemoteCall) {}

        internal IntPtr @this;
        internal int __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Browser.cfx_browser_get_identifier(@this);
        }
    }

    internal class CfxBrowserIsSameRemoteCall : RemoteCall {

        internal CfxBrowserIsSameRemoteCall()
            : base(RemoteCallId.CfxBrowserIsSameRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr that;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(that);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out that);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_is_same(@this, that);
        }
    }

    internal class CfxBrowserIsPopupRemoteCall : RemoteCall {

        internal CfxBrowserIsPopupRemoteCall()
            : base(RemoteCallId.CfxBrowserIsPopupRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_is_popup(@this);
        }
    }

    internal class CfxBrowserHasDocumentRemoteCall : RemoteCall {

        internal CfxBrowserHasDocumentRemoteCall()
            : base(RemoteCallId.CfxBrowserHasDocumentRemoteCall) {}

        internal IntPtr @this;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_has_document(@this);
        }
    }

    internal class CfxBrowserGetMainFrameRemoteCall : RemoteCall {

        internal CfxBrowserGetMainFrameRemoteCall()
            : base(RemoteCallId.CfxBrowserGetMainFrameRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Browser.cfx_browser_get_main_frame(@this);
        }
    }

    internal class CfxBrowserGetFocusedFrameRemoteCall : RemoteCall {

        internal CfxBrowserGetFocusedFrameRemoteCall()
            : base(RemoteCallId.CfxBrowserGetFocusedFrameRemoteCall) {}

        internal IntPtr @this;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Browser.cfx_browser_get_focused_frame(@this);
        }
    }

    internal class CfxBrowserGetFrameByIdentifierRemoteCall : RemoteCall {

        internal CfxBrowserGetFrameByIdentifierRemoteCall()
            : base(RemoteCallId.CfxBrowserGetFrameByIdentifierRemoteCall) {}

        internal IntPtr @this;
        internal long identifier;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(identifier);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out identifier);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.Browser.cfx_browser_get_frame_byident(@this, identifier);
        }
    }

    internal class CfxBrowserGetFrameRemoteCall : RemoteCall {

        internal CfxBrowserGetFrameRemoteCall()
            : base(RemoteCallId.CfxBrowserGetFrameRemoteCall) {}

        internal IntPtr @this;
        internal string name;
        internal IntPtr __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(name);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out name);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var name_pinned = new PinnedString(name);
            __retval = CfxApi.Browser.cfx_browser_get_frame(@this, name_pinned.Obj.PinnedPtr, name_pinned.Length);
            name_pinned.Obj.Free();
        }
    }

    internal class CfxBrowserGetFrameCountRemoteCall : RemoteCall {

        internal CfxBrowserGetFrameCountRemoteCall()
            : base(RemoteCallId.CfxBrowserGetFrameCountRemoteCall) {}

        internal IntPtr @this;
        internal ulong __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = (ulong)CfxApi.Browser.cfx_browser_get_frame_count(@this);
        }
    }

    internal class CfxBrowserGetFrameIdentifiersRemoteCall : RemoteCall {

        internal CfxBrowserGetFrameIdentifiersRemoteCall()
            : base(RemoteCallId.CfxBrowserGetFrameIdentifiersRemoteCall) {}

        internal IntPtr @this;
        internal long[] __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var identifiersCount = CfxApi.Browser.cfx_browser_get_frame_count(@this);
            __retval = new long[(ulong)identifiersCount];
            if(identifiersCount == UIntPtr.Zero) return;
            var retval_p = new PinnedObject(__retval);
            CfxApi.Browser.cfx_browser_get_frame_identifiers(@this, identifiersCount, retval_p.PinnedPtr);
            retval_p.Free();
        }
    }

    internal class CfxBrowserGetFrameNamesRemoteCall : RemoteCall {

        internal CfxBrowserGetFrameNamesRemoteCall()
            : base(RemoteCallId.CfxBrowserGetFrameNamesRemoteCall) {}

        internal IntPtr @this;
        internal System.Collections.Generic.List<string> __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = new System.Collections.Generic.List<string>();
            var list = StringFunctions.AllocCfxStringList();
            CfxApi.Browser.cfx_browser_get_frame_names(@this, list);
            StringFunctions.CfxStringListCopyToManaged(list, __retval);
            StringFunctions.FreeCfxStringList(list);
        }
    }

    internal class CfxBrowserSendProcessMessageRemoteCall : RemoteCall {

        internal CfxBrowserSendProcessMessageRemoteCall()
            : base(RemoteCallId.CfxBrowserSendProcessMessageRemoteCall) {}

        internal IntPtr @this;
        internal int targetProcess;
        internal IntPtr message;
        internal bool __retval;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(@this);
            h.Write(targetProcess);
            h.Write(message);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out @this);
            h.Read(out targetProcess);
            h.Read(out message);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(__retval);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out __retval);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = 0 != CfxApi.Browser.cfx_browser_send_process_message(@this, (int)targetProcess, message);
        }
    }

}