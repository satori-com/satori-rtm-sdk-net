﻿//------------------------------------------------------------------------------
// <auto-generated>                                                       
//     This code was generated by a tool.                                       
//                                                                              
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                      
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace Satori.Rtm
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;
    abstract public class ConnectionStepResult
    {
        public enum Id
        {
            disconnected,
            expectedReply,
            unexpectedReply,
            unsolicitedEvent,
            error
        }
        public interface IMatch
        {
            void OnDisconnected(Disconnected disconnected);
            void OnExpectedReply(ExpectedReply expectedReply);
            void OnUnexpectedReply(UnexpectedReply unexpectedReply);
            void OnUnsolicitedEvent(UnsolicitedEvent unsolicitedEvent);
            void OnError(Error error);
        }
        public interface IMatch<TMatch>
        {
            TMatch OnDisconnected(Disconnected disconnected);
            TMatch OnExpectedReply(ExpectedReply expectedReply);
            TMatch OnUnexpectedReply(UnexpectedReply unexpectedReply);
            TMatch OnUnsolicitedEvent(UnsolicitedEvent unsolicitedEvent);
            TMatch OnError(Error error);
        }
        public delegate void OnDisconnectedCallback(Disconnected disconnected);
        public delegate void OnExpectedReplyCallback(ExpectedReply expectedReply);
        public delegate void OnUnexpectedReplyCallback(UnexpectedReply unexpectedReply);
        public delegate void OnUnsolicitedEventCallback(UnsolicitedEvent unsolicitedEvent);
        public delegate void OnErrorCallback(Error error);
        public delegate TMatch OnDisconnectedCallback<TMatch>(Disconnected disconnected);
        public delegate TMatch OnExpectedReplyCallback<TMatch>(ExpectedReply expectedReply);
        public delegate TMatch OnUnexpectedReplyCallback<TMatch>(UnexpectedReply unexpectedReply);
        public delegate TMatch OnUnsolicitedEventCallback<TMatch>(UnsolicitedEvent unsolicitedEvent);
        public delegate TMatch OnErrorCallback<TMatch>(Error error);
        public readonly Id id;
        public class Disconnected : ConnectionStepResult
        {
            public Disconnected() : base(Id.disconnected)
            {
            }
            public override void Match(IMatch handler)
            {
                handler.OnDisconnected(this);
            }
            public override TMatch Match<TMatch>(IMatch<TMatch> handler)
            {
                return handler.OnDisconnected(this);
            }
            public override void Match(OnDisconnectedCallback disconnected, OnExpectedReplyCallback expectedReply, OnUnexpectedReplyCallback unexpectedReply, OnUnsolicitedEventCallback unsolicitedEvent, OnErrorCallback error)
            {
                disconnected(this);
            }
            public override TMatch Match<TMatch>(OnDisconnectedCallback<TMatch> disconnected, OnExpectedReplyCallback<TMatch> expectedReply, OnUnexpectedReplyCallback<TMatch> unexpectedReply, OnUnsolicitedEventCallback<TMatch> unsolicitedEvent, OnErrorCallback<TMatch> error)
            {
                return disconnected(this);
            }
            public override bool IsDisconnected()
            {
                return true;
            }
            public override Disconnected AsDisconnected()
            {
                return this;
            }
            public override bool OnDisconnected(OnDisconnectedCallback callback)
            {
                callback(this);
                return false;
            }
        }
        public abstract partial class ExpectedReply : ConnectionStepResult
        {
            public new enum Id
            {
                positive,
                negative,
                unknownOutcome
            }
            public new interface IMatch
            {
                void OnPositive(Positive positive);
                void OnNegative(Negative negative);
                void OnUnknownOutcome(UnknownOutcome unknownOutcome);
            }
            public new interface IMatch<TMatch>
            {
                TMatch OnPositive(Positive positive);
                TMatch OnNegative(Negative negative);
                TMatch OnUnknownOutcome(UnknownOutcome unknownOutcome);
            }
            public delegate void OnPositiveCallback(Positive positive);
            public delegate void OnNegativeCallback(Negative negative);
            public delegate void OnUnknownOutcomeCallback(UnknownOutcome unknownOutcome);
            public delegate TMatch OnPositiveCallback<TMatch>(Positive positive);
            public delegate TMatch OnNegativeCallback<TMatch>(Negative negative);
            public delegate TMatch OnUnknownOutcomeCallback<TMatch>(UnknownOutcome unknownOutcome);
            public readonly Pdu pdu;
            public class Positive : ExpectedReply
            {
                public Positive(Pdu pdu) : base(pdu, Id.positive)
                {
                }
                public override void Match(IMatch handler)
                {
                    handler.OnPositive(this);
                }
                public override TMatch Match<TMatch>(IMatch<TMatch> handler)
                {
                    return handler.OnPositive(this);
                }
                public override void Match(OnPositiveCallback positive, OnNegativeCallback negative, OnUnknownOutcomeCallback unknownOutcome)
                {
                    positive(this);
                }
                public override TMatch Match<TMatch>(OnPositiveCallback<TMatch> positive, OnNegativeCallback<TMatch> negative, OnUnknownOutcomeCallback<TMatch> unknownOutcome)
                {
                    return positive(this);
                }
                public override bool IsPositive()
                {
                    return true;
                }
                public override Positive AsPositive()
                {
                    return this;
                }
                public override bool OnPositive(OnPositiveCallback callback)
                {
                    callback(this);
                    return false;
                }
            }
            public class Negative : ExpectedReply
            {
                public Negative(Pdu pdu) : base(pdu, Id.negative)
                {
                }
                public override void Match(IMatch handler)
                {
                    handler.OnNegative(this);
                }
                public override TMatch Match<TMatch>(IMatch<TMatch> handler)
                {
                    return handler.OnNegative(this);
                }
                public override void Match(OnPositiveCallback positive, OnNegativeCallback negative, OnUnknownOutcomeCallback unknownOutcome)
                {
                    negative(this);
                }
                public override TMatch Match<TMatch>(OnPositiveCallback<TMatch> positive, OnNegativeCallback<TMatch> negative, OnUnknownOutcomeCallback<TMatch> unknownOutcome)
                {
                    return negative(this);
                }
                public override bool IsNegative()
                {
                    return true;
                }
                public override Negative AsNegative()
                {
                    return this;
                }
                public override bool OnNegative(OnNegativeCallback callback)
                {
                    callback(this);
                    return false;
                }
            }
            public class UnknownOutcome : ExpectedReply
            {
                public UnknownOutcome(Pdu pdu) : base(pdu, Id.unknownOutcome)
                {
                }
                public override void Match(IMatch handler)
                {
                    handler.OnUnknownOutcome(this);
                }
                public override TMatch Match<TMatch>(IMatch<TMatch> handler)
                {
                    return handler.OnUnknownOutcome(this);
                }
                public override void Match(OnPositiveCallback positive, OnNegativeCallback negative, OnUnknownOutcomeCallback unknownOutcome)
                {
                    unknownOutcome(this);
                }
                public override TMatch Match<TMatch>(OnPositiveCallback<TMatch> positive, OnNegativeCallback<TMatch> negative, OnUnknownOutcomeCallback<TMatch> unknownOutcome)
                {
                    return unknownOutcome(this);
                }
                public override bool IsUnknownOutcome()
                {
                    return true;
                }
                public override UnknownOutcome AsUnknownOutcome()
                {
                    return this;
                }
                public override bool OnUnknownOutcome(OnUnknownOutcomeCallback callback)
                {
                    callback(this);
                    return false;
                }
            }
            protected ExpectedReply(Pdu pdu, Id id) : base(ConnectionStepResult.Id.expectedReply)
            {
                this.pdu = pdu;
            }
            public abstract void Match(IMatch handler);
            public abstract TMatch Match<TMatch>(IMatch<TMatch> handler);
            public abstract void Match(OnPositiveCallback positive, OnNegativeCallback negative, OnUnknownOutcomeCallback unknownOutcome);
            public abstract TMatch Match<TMatch>(OnPositiveCallback<TMatch> positive, OnNegativeCallback<TMatch> negative, OnUnknownOutcomeCallback<TMatch> unknownOutcome);
            public virtual bool IsPositive()
            {
                return false;
            }
            public virtual bool IsNegative()
            {
                return false;
            }
            public virtual bool IsUnknownOutcome()
            {
                return false;
            }
            public virtual Positive AsPositive()
            {
                return null;
            }
            public virtual Negative AsNegative()
            {
                return null;
            }
            public virtual UnknownOutcome AsUnknownOutcome()
            {
                return null;
            }
            public virtual bool OnPositive(OnPositiveCallback callback)
            {
                return false;
            }
            public virtual bool OnNegative(OnNegativeCallback callback)
            {
                return false;
            }
            public virtual bool OnUnknownOutcome(OnUnknownOutcomeCallback callback)
            {
                return false;
            }
            public override void Match(ConnectionStepResult.IMatch handler)
            {
                handler.OnExpectedReply(this);
            }
            public override TMatch Match<TMatch>(ConnectionStepResult.IMatch<TMatch> handler)
            {
                return handler.OnExpectedReply(this);
            }
            public override void Match(OnDisconnectedCallback disconnected, OnExpectedReplyCallback expectedReply, OnUnexpectedReplyCallback unexpectedReply, OnUnsolicitedEventCallback unsolicitedEvent, OnErrorCallback error)
            {
                expectedReply(this);
            }
            public override TMatch Match<TMatch>(OnDisconnectedCallback<TMatch> disconnected, OnExpectedReplyCallback<TMatch> expectedReply, OnUnexpectedReplyCallback<TMatch> unexpectedReply, OnUnsolicitedEventCallback<TMatch> unsolicitedEvent, OnErrorCallback<TMatch> error)
            {
                return expectedReply(this);
            }
            public override bool IsExpectedReply()
            {
                return true;
            }
            public override ExpectedReply AsExpectedReply()
            {
                return this;
            }
            public override bool OnExpectedReply(OnExpectedReplyCallback callback)
            {
                callback(this);
                return true;
            }
        }
        public class UnexpectedReply : ConnectionStepResult
        {
            public readonly Pdu pdu;
            public UnexpectedReply(Pdu pdu) : base(Id.unexpectedReply)
            {
                this.pdu = pdu;
            }
            public override void Match(IMatch handler)
            {
                handler.OnUnexpectedReply(this);
            }
            public override TMatch Match<TMatch>(IMatch<TMatch> handler)
            {
                return handler.OnUnexpectedReply(this);
            }
            public override void Match(OnDisconnectedCallback disconnected, OnExpectedReplyCallback expectedReply, OnUnexpectedReplyCallback unexpectedReply, OnUnsolicitedEventCallback unsolicitedEvent, OnErrorCallback error)
            {
                unexpectedReply(this);
            }
            public override TMatch Match<TMatch>(OnDisconnectedCallback<TMatch> disconnected, OnExpectedReplyCallback<TMatch> expectedReply, OnUnexpectedReplyCallback<TMatch> unexpectedReply, OnUnsolicitedEventCallback<TMatch> unsolicitedEvent, OnErrorCallback<TMatch> error)
            {
                return unexpectedReply(this);
            }
            public override bool IsUnexpectedReply()
            {
                return true;
            }
            public override UnexpectedReply AsUnexpectedReply()
            {
                return this;
            }
            public override bool OnUnexpectedReply(OnUnexpectedReplyCallback callback)
            {
                callback(this);
                return false;
            }
        }
        public class UnsolicitedEvent : ConnectionStepResult
        {
            public readonly Pdu pdu;
            public UnsolicitedEvent(Pdu pdu) : base(Id.unsolicitedEvent)
            {
                this.pdu = pdu;
            }
            public override void Match(IMatch handler)
            {
                handler.OnUnsolicitedEvent(this);
            }
            public override TMatch Match<TMatch>(IMatch<TMatch> handler)
            {
                return handler.OnUnsolicitedEvent(this);
            }
            public override void Match(OnDisconnectedCallback disconnected, OnExpectedReplyCallback expectedReply, OnUnexpectedReplyCallback unexpectedReply, OnUnsolicitedEventCallback unsolicitedEvent, OnErrorCallback error)
            {
                unsolicitedEvent(this);
            }
            public override TMatch Match<TMatch>(OnDisconnectedCallback<TMatch> disconnected, OnExpectedReplyCallback<TMatch> expectedReply, OnUnexpectedReplyCallback<TMatch> unexpectedReply, OnUnsolicitedEventCallback<TMatch> unsolicitedEvent, OnErrorCallback<TMatch> error)
            {
                return unsolicitedEvent(this);
            }
            public override bool IsUnsolicitedEvent()
            {
                return true;
            }
            public override UnsolicitedEvent AsUnsolicitedEvent()
            {
                return this;
            }
            public override bool OnUnsolicitedEvent(OnUnsolicitedEventCallback callback)
            {
                callback(this);
                return false;
            }
        }
        public class Error : ConnectionStepResult
        {
            public readonly Exception error;
            public Error(Exception error) : base(Id.error)
            {
                this.error = error;
            }
            public override void Match(IMatch handler)
            {
                handler.OnError(this);
            }
            public override TMatch Match<TMatch>(IMatch<TMatch> handler)
            {
                return handler.OnError(this);
            }
            public override void Match(OnDisconnectedCallback disconnected, OnExpectedReplyCallback expectedReply, OnUnexpectedReplyCallback unexpectedReply, OnUnsolicitedEventCallback unsolicitedEvent, OnErrorCallback error)
            {
                error(this);
            }
            public override TMatch Match<TMatch>(OnDisconnectedCallback<TMatch> disconnected, OnExpectedReplyCallback<TMatch> expectedReply, OnUnexpectedReplyCallback<TMatch> unexpectedReply, OnUnsolicitedEventCallback<TMatch> unsolicitedEvent, OnErrorCallback<TMatch> error)
            {
                return error(this);
            }
            public override bool IsError()
            {
                return true;
            }
            public override Error AsError()
            {
                return this;
            }
            public override bool OnError(OnErrorCallback callback)
            {
                callback(this);
                return false;
            }
        }
        protected ConnectionStepResult(Id id)
        {
        }
        public abstract void Match(IMatch handler);
        public abstract TMatch Match<TMatch>(IMatch<TMatch> handler);
        public abstract void Match(OnDisconnectedCallback disconnected, OnExpectedReplyCallback expectedReply, OnUnexpectedReplyCallback unexpectedReply, OnUnsolicitedEventCallback unsolicitedEvent, OnErrorCallback error);
        public abstract TMatch Match<TMatch>(OnDisconnectedCallback<TMatch> disconnected, OnExpectedReplyCallback<TMatch> expectedReply, OnUnexpectedReplyCallback<TMatch> unexpectedReply, OnUnsolicitedEventCallback<TMatch> unsolicitedEvent, OnErrorCallback<TMatch> error);
        public virtual bool IsDisconnected()
        {
            return false;
        }
        public virtual bool IsExpectedReply()
        {
            return false;
        }
        public virtual bool IsUnexpectedReply()
        {
            return false;
        }
        public virtual bool IsUnsolicitedEvent()
        {
            return false;
        }
        public virtual bool IsError()
        {
            return false;
        }
        public virtual Disconnected AsDisconnected()
        {
            return null;
        }
        public virtual ExpectedReply AsExpectedReply()
        {
            return null;
        }
        public virtual UnexpectedReply AsUnexpectedReply()
        {
            return null;
        }
        public virtual UnsolicitedEvent AsUnsolicitedEvent()
        {
            return null;
        }
        public virtual Error AsError()
        {
            return null;
        }
        public virtual bool OnDisconnected(OnDisconnectedCallback callback)
        {
            return false;
        }
        public virtual bool OnExpectedReply(OnExpectedReplyCallback callback)
        {
            return false;
        }
        public virtual bool OnUnexpectedReply(OnUnexpectedReplyCallback callback)
        {
            return false;
        }
        public virtual bool OnUnsolicitedEvent(OnUnsolicitedEventCallback callback)
        {
            return false;
        }
        public virtual bool OnError(OnErrorCallback callback)
        {
            return false;
        }
    }
}
