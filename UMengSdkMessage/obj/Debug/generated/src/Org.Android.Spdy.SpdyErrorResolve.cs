using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyErrorResolve", DoNotGenerateAcw=true)]
	public sealed partial class SpdyErrorResolve : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']"
		[global::Android.Runtime.Register ("org/android/spdy/SpdyErrorResolve$ErrorCode", DoNotGenerateAcw=true)]
		public partial class ErrorCode : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_DEFAULT_ERROR']"
			[Register ("EASY_DEFAULT_ERROR")]
			public const int EasyDefaultError = (int) -2050;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_CANCEL']"
			[Register ("EASY_REASON_CANCEL")]
			public const int EasyReasonCancel = (int) -2005;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_CONN_ERROR']"
			[Register ("EASY_REASON_CONN_ERROR")]
			public const int EasyReasonConnError = (int) -2001;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_CONN_TIMEOUT']"
			[Register ("EASY_REASON_CONN_TIMEOUT")]
			public const int EasyReasonConnTimeout = (int) -2003;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_DISCONNECT']"
			[Register ("EASY_REASON_DISCONNECT")]
			public const int EasyReasonDisconnect = (int) -2002;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_INVALID_DATA']"
			[Register ("EASY_REASON_INVALID_DATA")]
			public const int EasyReasonInvalidData = (int) -2037;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_IO_ERROR']"
			[Register ("EASY_REASON_IO_ERROR")]
			public const int EasyReasonIoError = (int) -2030;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_NO_MEM']"
			[Register ("EASY_REASON_NO_MEM")]
			public const int EasyReasonNoMem = (int) -2031;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_READ_ERROR']"
			[Register ("EASY_REASON_READ_ERROR")]
			public const int EasyReasonReadError = (int) -2034;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_SERVER_CLOSE']"
			[Register ("EASY_REASON_SERVER_CLOSE")]
			public const int EasyReasonServerClose = (int) -2032;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_SESSION_TIMEOUT']"
			[Register ("EASY_REASON_SESSION_TIMEOUT")]
			public const int EasyReasonSessionTimeout = (int) -2004;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_SLIGHTSSL_ERROR']"
			[Register ("EASY_REASON_SLIGHTSSL_ERROR")]
			public const int EasyReasonSlightsslError = (int) -2035;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_SPDYINIT_ERROR']"
			[Register ("EASY_REASON_SPDYINIT_ERROR")]
			public const int EasyReasonSpdyinitError = (int) -2036;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_REASON_WRITE_ERROR']"
			[Register ("EASY_REASON_WRITE_ERROR")]
			public const int EasyReasonWriteError = (int) -2033;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_CANCEL']"
			[Register ("EASY_SPDY_CANCEL")]
			public const int EasySpdyCancel = (int) -2014;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_FLOW_CONTROL_ERROR']"
			[Register ("EASY_SPDY_FLOW_CONTROL_ERROR")]
			public const int EasySpdyFlowControlError = (int) -2016;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_FRAME_TOO_LARGE']"
			[Register ("EASY_SPDY_FRAME_TOO_LARGE")]
			public const int EasySpdyFrameTooLarge = (int) -2020;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_INTERNAL_ERROR']"
			[Register ("EASY_SPDY_INTERNAL_ERROR")]
			public const int EasySpdyInternalError = (int) -2015;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_INVALID_CREDENTIALS']"
			[Register ("EASY_SPDY_INVALID_CREDENTIALS")]
			public const int EasySpdyInvalidCredentials = (int) -2019;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_INVALID_STREAM']"
			[Register ("EASY_SPDY_INVALID_STREAM")]
			public const int EasySpdyInvalidStream = (int) -2011;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_PROTOCOL_ERROR']"
			[Register ("EASY_SPDY_PROTOCOL_ERROR")]
			public const int EasySpdyProtocolError = (int) -2010;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_REFUSED_STREAM']"
			[Register ("EASY_SPDY_REFUSED_STREAM")]
			public const int EasySpdyRefusedStream = (int) -2012;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_SESSION_INTERNAL_ERROR']"
			[Register ("EASY_SPDY_SESSION_INTERNAL_ERROR")]
			public const int EasySpdySessionInternalError = (int) -2022;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_SESSION_PROTOCOL_ERROR']"
			[Register ("EASY_SPDY_SESSION_PROTOCOL_ERROR")]
			public const int EasySpdySessionProtocolError = (int) -2021;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_STREAM_ALREADY_CLOSED']"
			[Register ("EASY_SPDY_STREAM_ALREADY_CLOSED")]
			public const int EasySpdyStreamAlreadyClosed = (int) -2018;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_STREAM_IN_USE']"
			[Register ("EASY_SPDY_STREAM_IN_USE")]
			public const int EasySpdyStreamInUse = (int) -2017;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='EASY_SPDY_UNSUPPORTED_VERSION']"
			[Register ("EASY_SPDY_UNSUPPORTED_VERSION")]
			public const int EasySpdyUnsupportedVersion = (int) -2013;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_CALLBACK_FAILURE']"
			[Register ("SPDYLAY_ERR_CALLBACK_FAILURE")]
			public const int SpdylayErrCallbackFailure = (int) -902;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_DEFERRED']"
			[Register ("SPDYLAY_ERR_DEFERRED")]
			public const int SpdylayErrDeferred = (int) -508;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_DEFERRED_DATA_EXIST']"
			[Register ("SPDYLAY_ERR_DEFERRED_DATA_EXIST")]
			public const int SpdylayErrDeferredDataExist = (int) -515;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_EOF']"
			[Register ("SPDYLAY_ERR_EOF")]
			public const int SpdylayErrEof = (int) -507;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_FATAL']"
			[Register ("SPDYLAY_ERR_FATAL")]
			public const int SpdylayErrFatal = (int) -900;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_FRAME_TOO_LARGE']"
			[Register ("SPDYLAY_ERR_FRAME_TOO_LARGE")]
			public const int SpdylayErrFrameTooLarge = (int) -522;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_GOAWAY_ALREADY_SENT']"
			[Register ("SPDYLAY_ERR_GOAWAY_ALREADY_SENT")]
			public const int SpdylayErrGoawayAlreadySent = (int) -517;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_GZIP']"
			[Register ("SPDYLAY_ERR_GZIP")]
			public const int SpdylayErrGzip = (int) -520;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_INVALID_ARGUMENT']"
			[Register ("SPDYLAY_ERR_INVALID_ARGUMENT")]
			public const int SpdylayErrInvalidArgument = (int) -501;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_INVALID_FRAME']"
			[Register ("SPDYLAY_ERR_INVALID_FRAME")]
			public const int SpdylayErrInvalidFrame = (int) -506;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_INVALID_HEADER_BLOCK']"
			[Register ("SPDYLAY_ERR_INVALID_HEADER_BLOCK")]
			public const int SpdylayErrInvalidHeaderBlock = (int) -518;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_INVALID_STATE']"
			[Register ("SPDYLAY_ERR_INVALID_STATE")]
			public const int SpdylayErrInvalidState = (int) -519;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_INVALID_STREAM_ID']"
			[Register ("SPDYLAY_ERR_INVALID_STREAM_ID")]
			public const int SpdylayErrInvalidStreamId = (int) -513;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_INVALID_STREAM_STATE']"
			[Register ("SPDYLAY_ERR_INVALID_STREAM_STATE")]
			public const int SpdylayErrInvalidStreamState = (int) -514;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_NOMEM']"
			[Register ("SPDYLAY_ERR_NOMEM")]
			public const int SpdylayErrNomem = (int) -901;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_PROTO']"
			[Register ("SPDYLAY_ERR_PROTO")]
			public const int SpdylayErrProto = (int) -505;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_STREAM_CLOSED']"
			[Register ("SPDYLAY_ERR_STREAM_CLOSED")]
			public const int SpdylayErrStreamClosed = (int) -510;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_STREAM_CLOSING']"
			[Register ("SPDYLAY_ERR_STREAM_CLOSING")]
			public const int SpdylayErrStreamClosing = (int) -511;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_STREAM_ID_NOT_AVAILABLE']"
			[Register ("SPDYLAY_ERR_STREAM_ID_NOT_AVAILABLE")]
			public const int SpdylayErrStreamIdNotAvailable = (int) -509;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_STREAM_SHUT_WR']"
			[Register ("SPDYLAY_ERR_STREAM_SHUT_WR")]
			public const int SpdylayErrStreamShutWr = (int) -512;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_SYN_STREAM_NOT_ALLOWED']"
			[Register ("SPDYLAY_ERR_SYN_STREAM_NOT_ALLOWED")]
			public const int SpdylayErrSynStreamNotAllowed = (int) -516;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_TEMPORAL_CALLBACK_FAILURE']"
			[Register ("SPDYLAY_ERR_TEMPORAL_CALLBACK_FAILURE")]
			public const int SpdylayErrTemporalCallbackFailure = (int) -521;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_UNSUPPORTED_VERSION']"
			[Register ("SPDYLAY_ERR_UNSUPPORTED_VERSION")]
			public const int SpdylayErrUnsupportedVersion = (int) -503;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_WOULDBLOCK']"
			[Register ("SPDYLAY_ERR_WOULDBLOCK")]
			public const int SpdylayErrWouldblock = (int) -504;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDYLAY_ERR_ZLIB']"
			[Register ("SPDYLAY_ERR_ZLIB")]
			public const int SpdylayErrZlib = (int) -502;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_CONNECT_BASE']"
			[Register ("SPDY_CONNECT_BASE")]
			public const int SpdyConnectBase = (int) -1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_CONNECT_DOWN']"
			[Register ("SPDY_CONNECT_DOWN")]
			public const int SpdyConnectDown = (int) -1003;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_CONNECT_ERROR']"
			[Register ("SPDY_CONNECT_ERROR")]
			public const int SpdyConnectError = (int) -1002;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_CONNECT_MAX']"
			[Register ("SPDY_CONNECT_MAX")]
			public const int SpdyConnectMax = (int) -1050;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_CONNECT_TIMEOUT']"
			[Register ("SPDY_CONNECT_TIMEOUT")]
			public const int SpdyConnectTimeout = (int) -1001;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_HOST_UNREACH']"
			[Register ("SPDY_HOST_UNREACH")]
			public const int SpdyHostUnreach = (int) -1054;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_JNI_ERR_ASYNC_CLOSE']"
			[Register ("SPDY_JNI_ERR_ASYNC_CLOSE")]
			public const int SpdyJniErrAsyncClose = (int) -1104;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_JNI_ERR_BASE']"
			[Register ("SPDY_JNI_ERR_BASE")]
			public const int SpdyJniErrBase = (int) -1101;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_JNI_ERR_INVLID_PARAM']"
			[Register ("SPDY_JNI_ERR_INVLID_PARAM")]
			public const int SpdyJniErrInvlidParam = (int) -1102;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_JNI_ERR_MAX']"
			[Register ("SPDY_JNI_ERR_MAX")]
			public const int SpdyJniErrMax = (int) -1200;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_JNI_ERR_NOT_SUPPORT_API']"
			[Register ("SPDY_JNI_ERR_NOT_SUPPORT_API")]
			public const int SpdyJniErrNotSupportApi = (int) -1107;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_JNI_ERR_NO_MEM']"
			[Register ("SPDY_JNI_ERR_NO_MEM")]
			public const int SpdyJniErrNoMem = (int) -1101;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_JNI_ERR_STATUS_ERR']"
			[Register ("SPDY_JNI_ERR_STATUS_ERR")]
			public const int SpdyJniErrStatusErr = (int) -1103;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_POLL_ERROR']"
			[Register ("SPDY_POLL_ERROR")]
			public const int SpdyPollError = (int) -1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SESSION_EXCEED_MAXED']"
			[Register ("SPDY_SESSION_EXCEED_MAXED")]
			public const int SpdySessionExceedMaxed = (int) -1105;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_CERT_INVLID']"
			[Register ("SPDY_SSL_CERT_INVLID")]
			public const int SpdySslCertInvlid = (int) -1006;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_CERT_TOO_LARGE']"
			[Register ("SPDY_SSL_CERT_TOO_LARGE")]
			public const int SpdySslCertTooLarge = (int) -1008;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_EXPIRE_TIME_ERR']"
			[Register ("SPDY_SSL_EXPIRE_TIME_ERR")]
			public const int SpdySslExpireTimeErr = (int) -1004;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_FRAME_LENGTH_ERR']"
			[Register ("SPDY_SSL_FRAME_LENGTH_ERR")]
			public const int SpdySslFrameLengthErr = (int) -1007;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_FRAME_TYPE_ERR']"
			[Register ("SPDY_SSL_FRAME_TYPE_ERR")]
			public const int SpdySslFrameTypeErr = (int) -1010;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_INTENAL_ERR']"
			[Register ("SPDY_SSL_INTENAL_ERR")]
			public const int SpdySslIntenalErr = (int) -1014;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_INVALID_PARAM']"
			[Register ("SPDY_SSL_INVALID_PARAM")]
			public const int SpdySslInvalidParam = (int) -1013;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_MAGIC_ERR']"
			[Register ("SPDY_SSL_MAGIC_ERR")]
			public const int SpdySslMagicErr = (int) -1005;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_RSA_PUB_ERROR']"
			[Register ("SPDY_SSL_RSA_PUB_ERROR")]
			public const int SpdySslRsaPubError = (int) -1012;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_TYPE_ERR']"
			[Register ("SPDY_SSL_TYPE_ERR")]
			public const int SpdySslTypeErr = (int) -1009;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/field[@name='SPDY_SSL_WRITE_END_ERR']"
			[Register ("SPDY_SSL_WRITE_END_ERR")]
			public const int SpdySslWriteEndErr = (int) -1011;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/android/spdy/SpdyErrorResolve$ErrorCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ErrorCode); }
			}

			protected ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve.ErrorCode']/constructor[@name='SpdyErrorResolve.ErrorCode' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public ErrorCode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ErrorCode)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyErrorResolve", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyErrorResolve); }
		}

		internal SpdyErrorResolve (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve']/constructor[@name='SpdyErrorResolve' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SpdyErrorResolve () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpdyErrorResolve)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_spdyResolve_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorResolve']/method[@name='spdyResolve' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("spdyResolve", "(I)V", "")]
		public static void SpdyResolve (int p0)
		{
			if (id_spdyResolve_I == IntPtr.Zero)
				id_spdyResolve_I = JNIEnv.GetStaticMethodID (class_ref, "spdyResolve", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_spdyResolve_I, new JValue (p0));
		}

	}
}
