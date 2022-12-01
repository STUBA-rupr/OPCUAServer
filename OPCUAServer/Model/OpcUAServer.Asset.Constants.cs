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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OpcUAServer.Asset
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint AssetType_DoService = 7;

        /// <remarks />
        public const uint AssetType_Previous_DoService = 14;

        /// <remarks />
        public const uint AssetType_Next_DoService = 21;

        /// <remarks />
        public const uint VehicleType_Previous_DoService = 35;

        /// <remarks />
        public const uint VehicleType_Next_DoService = 42;

        /// <remarks />
        public const uint MojVozen01_DoService = 53;

        /// <remarks />
        public const uint MojVozen01_Previous_DoService = 60;

        /// <remarks />
        public const uint MojVozen01_Next_DoService = 67;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint AssetType_Previous = 8;

        /// <remarks />
        public const uint AssetType_Next = 15;

        /// <remarks />
        public const uint MojVozen01 = 47;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint AssetType = 1;

        /// <remarks />
        public const uint VehicleType = 22;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint AssetType_LifeTime = 2;

        /// <remarks />
        public const uint AssetType_MaxSpeed = 3;

        /// <remarks />
        public const uint AssetType_Health = 4;

        /// <remarks />
        public const uint AssetType_LastServiced = 5;

        /// <remarks />
        public const uint AssetType_Possition = 6;

        /// <remarks />
        public const uint AssetType_Previous_LifeTime = 9;

        /// <remarks />
        public const uint AssetType_Previous_MaxSpeed = 10;

        /// <remarks />
        public const uint AssetType_Previous_Health = 11;

        /// <remarks />
        public const uint AssetType_Previous_LastServiced = 12;

        /// <remarks />
        public const uint AssetType_Previous_Possition = 13;

        /// <remarks />
        public const uint AssetType_Next_LifeTime = 16;

        /// <remarks />
        public const uint AssetType_Next_MaxSpeed = 17;

        /// <remarks />
        public const uint AssetType_Next_Health = 18;

        /// <remarks />
        public const uint AssetType_Next_LastServiced = 19;

        /// <remarks />
        public const uint AssetType_Next_Possition = 20;

        /// <remarks />
        public const uint VehicleType_Previous_LifeTime = 30;

        /// <remarks />
        public const uint VehicleType_Previous_MaxSpeed = 31;

        /// <remarks />
        public const uint VehicleType_Previous_Health = 32;

        /// <remarks />
        public const uint VehicleType_Previous_LastServiced = 33;

        /// <remarks />
        public const uint VehicleType_Previous_Possition = 34;

        /// <remarks />
        public const uint VehicleType_Next_LifeTime = 37;

        /// <remarks />
        public const uint VehicleType_Next_MaxSpeed = 38;

        /// <remarks />
        public const uint VehicleType_Next_Health = 39;

        /// <remarks />
        public const uint VehicleType_Next_LastServiced = 40;

        /// <remarks />
        public const uint VehicleType_Next_Possition = 41;

        /// <remarks />
        public const uint VehicleType_Speed = 43;

        /// <remarks />
        public const uint VehicleType_Load = 44;

        /// <remarks />
        public const uint VehicleType_Utilization = 45;

        /// <remarks />
        public const uint VehicleType_Direction = 46;

        /// <remarks />
        public const uint MojVozen01_LifeTime = 48;

        /// <remarks />
        public const uint MojVozen01_MaxSpeed = 49;

        /// <remarks />
        public const uint MojVozen01_Health = 50;

        /// <remarks />
        public const uint MojVozen01_LastServiced = 51;

        /// <remarks />
        public const uint MojVozen01_Possition = 52;

        /// <remarks />
        public const uint MojVozen01_Previous_LifeTime = 55;

        /// <remarks />
        public const uint MojVozen01_Previous_MaxSpeed = 56;

        /// <remarks />
        public const uint MojVozen01_Previous_Health = 57;

        /// <remarks />
        public const uint MojVozen01_Previous_LastServiced = 58;

        /// <remarks />
        public const uint MojVozen01_Previous_Possition = 59;

        /// <remarks />
        public const uint MojVozen01_Next_LifeTime = 62;

        /// <remarks />
        public const uint MojVozen01_Next_MaxSpeed = 63;

        /// <remarks />
        public const uint MojVozen01_Next_Health = 64;

        /// <remarks />
        public const uint MojVozen01_Next_LastServiced = 65;

        /// <remarks />
        public const uint MojVozen01_Next_Possition = 66;

        /// <remarks />
        public const uint MojVozen01_Speed = 68;

        /// <remarks />
        public const uint MojVozen01_Load = 69;

        /// <remarks />
        public const uint MojVozen01_Utilization = 70;

        /// <remarks />
        public const uint MojVozen01_Direction = 71;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AssetType_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.AssetType_DoService, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Previous_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.AssetType_Previous_DoService, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Next_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.AssetType_Next_DoService, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Previous_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.VehicleType_Previous_DoService, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Next_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.VehicleType_Next_DoService, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.MojVozen01_DoService, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Previous_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.MojVozen01_Previous_DoService, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Next_DoService = new ExpandedNodeId(OpcUAServer.Asset.Methods.MojVozen01_Next_DoService, OpcUAServer.Asset.Namespaces.Asset);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Previous = new ExpandedNodeId(OpcUAServer.Asset.Objects.AssetType_Previous, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Next = new ExpandedNodeId(OpcUAServer.Asset.Objects.AssetType_Next, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01 = new ExpandedNodeId(OpcUAServer.Asset.Objects.MojVozen01, OpcUAServer.Asset.Namespaces.Asset);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AssetType = new ExpandedNodeId(OpcUAServer.Asset.ObjectTypes.AssetType, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType = new ExpandedNodeId(OpcUAServer.Asset.ObjectTypes.VehicleType, OpcUAServer.Asset.Namespaces.Asset);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AssetType_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Previous_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Previous_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Previous_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Previous_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Previous_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Previous_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Previous_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Previous_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Previous_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Previous_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Next_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Next_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Next_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Next_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Next_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Next_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Next_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Next_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId AssetType_Next_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.AssetType_Next_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Previous_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Previous_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Previous_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Previous_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Previous_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Previous_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Previous_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Previous_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Previous_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Previous_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Next_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Next_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Next_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Next_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Next_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Next_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Next_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Next_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Next_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Next_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Speed = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Speed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Load = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Load, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Utilization = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Utilization, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId VehicleType_Direction = new ExpandedNodeId(OpcUAServer.Asset.Variables.VehicleType_Direction, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Previous_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Previous_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Previous_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Previous_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Previous_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Previous_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Previous_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Previous_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Previous_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Previous_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Next_LifeTime = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Next_LifeTime, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Next_MaxSpeed = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Next_MaxSpeed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Next_Health = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Next_Health, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Next_LastServiced = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Next_LastServiced, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Next_Possition = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Next_Possition, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Speed = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Speed, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Load = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Load, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Utilization = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Utilization, OpcUAServer.Asset.Namespaces.Asset);

        /// <remarks />
        public static readonly ExpandedNodeId MojVozen01_Direction = new ExpandedNodeId(OpcUAServer.Asset.Variables.MojVozen01_Direction, OpcUAServer.Asset.Namespaces.Asset);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AssetType = "AssetType";

        /// <remarks />
        public const string Direction = "Direction";

        /// <remarks />
        public const string DoService = "DoService";

        /// <remarks />
        public const string Health = "Health";

        /// <remarks />
        public const string LastServiced = "LastServiced";

        /// <remarks />
        public const string LifeTime = "LifeTime";

        /// <remarks />
        public const string Load = "Load";

        /// <remarks />
        public const string MaxSpeed = "MaxSpeed";

        /// <remarks />
        public const string MojVozen01 = "MojVozen #1";

        /// <remarks />
        public const string Next = "Next";

        /// <remarks />
        public const string Possition = "Possition";

        /// <remarks />
        public const string Previous = "Previous";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string Utilization = "Utilization";

        /// <remarks />
        public const string VehicleType = "VehicleType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the Asset namespace (.NET code namespace is 'OpcUAServer.Asset').
        /// </summary>
        public const string Asset = "http://fei.com/Hudak-Michalovic/";
    }
    #endregion
}