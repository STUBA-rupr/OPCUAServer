/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OpcUAServer.Asset
{
    #region AssetState Class
    #if (!OPCUA_EXCLUDE_AssetState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AssetState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public AssetState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUAServer.Asset.ObjectTypes.AssetType, OpcUAServer.Asset.Namespaces.Asset, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "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";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<int> LifeTime
        {
            get
            {
                return m_lifeTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lifeTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lifeTime = value;
            }
        }

        /// <remarks />
        public PropertyState<float> MaxSpeed
        {
            get
            {
                return m_maxSpeed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxSpeed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxSpeed = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Health
        {
            get
            {
                return m_health;
            }

            set
            {
                if (!Object.ReferenceEquals(m_health, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_health = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<DateTime> LastServiced
        {
            get
            {
                return m_lastServiced;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastServiced, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastServiced = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<Vector> Possition
        {
            get
            {
                return m_possition;
            }

            set
            {
                if (!Object.ReferenceEquals(m_possition, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_possition = value;
            }
        }

        /// <remarks />
        public MethodState DoService
        {
            get
            {
                return m_doServiceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_doServiceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_doServiceMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_lifeTime != null)
            {
                children.Add(m_lifeTime);
            }

            if (m_maxSpeed != null)
            {
                children.Add(m_maxSpeed);
            }

            if (m_health != null)
            {
                children.Add(m_health);
            }

            if (m_lastServiced != null)
            {
                children.Add(m_lastServiced);
            }

            if (m_possition != null)
            {
                children.Add(m_possition);
            }

            if (m_doServiceMethod != null)
            {
                children.Add(m_doServiceMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OpcUAServer.Asset.BrowseNames.LifeTime:
                {
                    if (createOrReplace)
                    {
                        if (LifeTime == null)
                        {
                            if (replacement == null)
                            {
                                LifeTime = new PropertyState<int>(this);
                            }
                            else
                            {
                                LifeTime = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = LifeTime;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.MaxSpeed:
                {
                    if (createOrReplace)
                    {
                        if (MaxSpeed == null)
                        {
                            if (replacement == null)
                            {
                                MaxSpeed = new PropertyState<float>(this);
                            }
                            else
                            {
                                MaxSpeed = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = MaxSpeed;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.Health:
                {
                    if (createOrReplace)
                    {
                        if (Health == null)
                        {
                            if (replacement == null)
                            {
                                Health = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Health = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Health;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.LastServiced:
                {
                    if (createOrReplace)
                    {
                        if (LastServiced == null)
                        {
                            if (replacement == null)
                            {
                                LastServiced = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                LastServiced = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastServiced;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.Possition:
                {
                    if (createOrReplace)
                    {
                        if (Possition == null)
                        {
                            if (replacement == null)
                            {
                                Possition = new BaseDataVariableState<Vector>(this);
                            }
                            else
                            {
                                Possition = (BaseDataVariableState<Vector>)replacement;
                            }
                        }
                    }

                    instance = Possition;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.DoService:
                {
                    if (createOrReplace)
                    {
                        if (DoService == null)
                        {
                            if (replacement == null)
                            {
                                DoService = new MethodState(this);
                            }
                            else
                            {
                                DoService = (MethodState)replacement;
                            }
                        }
                    }

                    instance = DoService;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<int> m_lifeTime;
        private PropertyState<float> m_maxSpeed;
        private BaseDataVariableState<int> m_health;
        private BaseDataVariableState<DateTime> m_lastServiced;
        private BaseDataVariableState<Vector> m_possition;
        private MethodState m_doServiceMethod;
        #endregion
    }
    #endif
    #endregion

    #region VehicleState Class
    #if (!OPCUA_EXCLUDE_VehicleState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VehicleState : AssetState
    {
        #region Constructors
        /// <remarks />
        public VehicleState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OpcUAServer.Asset.ObjectTypes.VehicleType, OpcUAServer.Asset.Namespaces.Asset, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vZmVpLmNvbS9IdWRhay1NaWNoYWxvdmljL/////8EYIACAQAAAAEAEwAAAFZl" +
           "aGljbGVUeXBlSW5zdGFuY2UBARYAAQEWABYAAAD/////CgAAADVgqQoCAAAAAQAIAAAATGlmZVRpbWUB" +
           "ARcAAwAAAAAVAAAATGlmZSB0aW1lIGluIG1pbnV0ZXMuAC4ARBcAAAAGoAUAAAAG/////wEB/////wAA" +
           "AAA1YKkKAgAAAAEACAAAAE1heFNwZWVkAQEYAAMAAAAAEgAAAE1heCBzcGVlZCBpbiBrbS9oLgAuAEQY" +
           "AAAACgAAAAAACv////8BAf////8AAAAANWCpCgIAAAABAAYAAABIZWFsdGgBARkAAwAAAAARAAAASGVh" +
           "bHQgaW4gcGVyY2VudC4ALwA/GQAAAAZkAAAAAAb/////AwP/////AAAAADVgqQoCAAAAAQAMAAAATGFz" +
           "dFNlcnZpY2VkAQEaAAMAAAAAJgAAAFRoZSBVVEMgZGF0ZSB0aW1lIG9mIHRoZSBsYXN0IHNlcnZpY2Uu" +
           "AC8APxoAAAANAKL0aDn72AEADf////8DA/////8AAAAANWCJCgIAAAABAAkAAABQb3NzaXRpb24BARsA" +
           "AwAAAAAUAAAAUG9zc2l0aW9uIGFzIHZlY3Rvci4ALwA/GwAAAAEAd0n/////AwP/////AAAAACRhggoE" +
           "AAAAAQAJAAAARG9TZXJ2aWNlAQEcAAMAAAAANgAAAFNldHMgTGFzdFNlcnZpY2VkIHZhcmlhYmxlIHdp" +
           "dGggY3VycmVudCBVVEMgZGF0ZSB0aW1lLgAvAQEHABwAAAABAf////8AAAAANWCpCgIAAAABAAUAAABT" +
           "cGVlZAEBKwADAAAAABYAAABDdXJyZW50IHNwZWVkIGluIGttL2guAC8APysAAAAKAAAAAAAK/////wMD" +
           "/////wAAAAA1YKkKAgAAAAEABAAAAExvYWQBASwAAwAAAAAQAAAATG9hZCBpbiBwZXJjZW50LgAvAD8s" +
           "AAAABgAAAAAABv////8DA/////8AAAAANWCpCgIAAAABAAsAAABVdGlsaXphdGlvbgEBLQADAAAAABcA" +
           "AABVdGlsaXphdGlvbiBpbiBwZXJjZW50LgAvAD8tAAAABgAAAAAABv////8DA/////8AAAAANWCpCgIA" +
           "AAABAAkAAABEaXJlY3Rpb24BAS4AAwAAAAATAAAATW92ZW1lbnQgZGlyZWN0aW9uLgAvAD8uAAAADAAA" +
           "AAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<float> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Load
        {
            get
            {
                return m_load;
            }

            set
            {
                if (!Object.ReferenceEquals(m_load, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_load = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Utilization
        {
            get
            {
                return m_utilization;
            }

            set
            {
                if (!Object.ReferenceEquals(m_utilization, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_utilization = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> Direction
        {
            get
            {
                return m_direction;
            }

            set
            {
                if (!Object.ReferenceEquals(m_direction, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_direction = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            if (m_load != null)
            {
                children.Add(m_load);
            }

            if (m_utilization != null)
            {
                children.Add(m_utilization);
            }

            if (m_direction != null)
            {
                children.Add(m_direction);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OpcUAServer.Asset.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new BaseDataVariableState<float>(this);
                            }
                            else
                            {
                                Speed = (BaseDataVariableState<float>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.Load:
                {
                    if (createOrReplace)
                    {
                        if (Load == null)
                        {
                            if (replacement == null)
                            {
                                Load = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Load = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Load;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.Utilization:
                {
                    if (createOrReplace)
                    {
                        if (Utilization == null)
                        {
                            if (replacement == null)
                            {
                                Utilization = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Utilization = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Utilization;
                    break;
                }

                case OpcUAServer.Asset.BrowseNames.Direction:
                {
                    if (createOrReplace)
                    {
                        if (Direction == null)
                        {
                            if (replacement == null)
                            {
                                Direction = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Direction = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Direction;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<float> m_speed;
        private BaseDataVariableState<int> m_load;
        private BaseDataVariableState<int> m_utilization;
        private BaseDataVariableState<string> m_direction;
        #endregion
    }
    #endif
    #endregion
}