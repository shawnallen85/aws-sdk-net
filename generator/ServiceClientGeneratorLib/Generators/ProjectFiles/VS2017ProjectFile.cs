﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class VS2017ProjectFile : VS2017ProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<Project Sdk=\"Microsoft.NET.Sdk\">\r\n  <PropertyGroup>\r\n    <TargetFramework>");
            
            #line 9 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["TargetFramework"]));
            
            #line default
            #line hidden
            this.Write("</TargetFramework>\r\n    <DefineConstants>$(DefineConstants);");
            
            #line 10 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <DebugType>portable</DebugType>\r\n    <GenerateDocumentati" +
                    "onFile>true</GenerateDocumentationFile>\r\n    <AssemblyName>");
            
            #line 13 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <PackageId>");
            
            #line 14 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(@"</PackageId>

    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>

");
            
            #line 25 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(this.Session.ContainsKey("FrameworkPathOverride") && !string.IsNullOrEmpty((string)Session["FrameworkPathOverride"]))
    {

            
            #line default
            #line hidden
            this.Write("    <!-- workaround per https://github.com/Microsoft/msbuild/issues/1333 -->\r\n   " +
                    " <FrameworkPathOverride>");
            
            #line 30 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["FrameworkPathOverride"].ToString()));
            
            #line default
            #line hidden
            this.Write("</FrameworkPathOverride>\r\n");
            
            #line 31 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    
    if(this.Session.ContainsKey("ReferencePath") && !string.IsNullOrEmpty((string)Session["ReferencePath"]))
    {

            
            #line default
            #line hidden
            this.Write("    <ReferencePath>");
            
            #line 37 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ReferencePath"].ToString()));
            
            #line default
            #line hidden
            this.Write("</ReferencePath>\r\n");
            
            #line 38 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(this.Session.ContainsKey("NoWarn") && !string.IsNullOrEmpty((string)Session["NoWarn"]))
    {

            
            #line default
            #line hidden
            this.Write("    <NoWarn>");
            
            #line 44 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NoWarn"].ToString()));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 45 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(this.Session.ContainsKey("OutputPathOverride") && !string.IsNullOrEmpty((string)Session["OutputPathOverride"]))
    {

            
            #line default
            #line hidden
            this.Write("    <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>\r" +
                    "\n    <OutputPath>");
            
            #line 52 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["OutputPathOverride"].ToString()));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n");
            
            #line 53 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            
            #line 56 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if (string.Compare(this.Session["TargetFramework"].ToString(), "netstandard1.3") == 0)
    {

            
            #line default
            #line hidden
            this.Write("    <NetStandardImplicitPackageVersion>1.6.0</NetStandardImplicitPackageVersion>\r" +
                    "\n");
            
            #line 61 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </PropertyGroup>\r\n\r\n");
            
            #line 66 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if (this.Session.ContainsKey("SignBinaries") && (bool)Session["SignBinaries"])
    {

            
            #line default
            #line hidden
            this.Write(@"  <Choose>
    <When Condition="" '$(AWSKeyFile)' == '' "">
      <PropertyGroup>
        <AssemblyOriginatorKeyFile>..\..\..\awssdk.dll.snk</AssemblyOriginatorKeyFile>
      </PropertyGroup>
    </When>
    <Otherwise>
      <PropertyGroup>
        <AssemblyOriginatorKeyFile>$(AWSKeyFile)</AssemblyOriginatorKeyFile>
      </PropertyGroup>
    </Otherwise>
  </Choose>

");
            
            #line 83 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(this.Session.ContainsKey("ExternalFilesInclude"))
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <Compile Include=\"");
            
            #line 90 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ExternalFilesInclude"]));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n  </ItemGroup>\r\n");
            
            #line 92 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(this.Session.ContainsKey("CompileRemoveList") && this.Session["CompileRemoveList"] != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 99 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        IList<string> compileRemoveList = this.Session["CompileRemoveList"] as IList<string>;
        foreach(var compileRemoveEntry in compileRemoveList)
        {
		  if(compileRemoveEntry.ToString()=="bin"||compileRemoveEntry.ToString()=="obj")
		  {

            
            #line default
            #line hidden
            this.Write("    <Compile Remove=\"**/");
            
            #line 106 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(compileRemoveEntry.ToString()));
            
            #line default
            #line hidden
            this.Write("/**\"/>\r\n\t<None Remove=\"**/");
            
            #line 107 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(compileRemoveEntry.ToString()));
            
            #line default
            #line hidden
            this.Write("/**\" />\r\n");
            
            #line 108 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

			continue;
		  }

            
            #line default
            #line hidden
            this.Write("    <Compile Remove=\"**/");
            
            #line 112 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(compileRemoveEntry.ToString()));
            
            #line default
            #line hidden
            this.Write("/**\"/>\r\n");
            
            #line 113 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 118 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            
            #line 121 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(this.Session.ContainsKey("ProjectReferenceList") && this.Session["ProjectReferenceList"] != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 126 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        var projectReferenceList = this.Session["ProjectReferenceList"] as IList<ProjectFileCreator.ProjectReference>;
        foreach(var projectReference in projectReferenceList)
        {

            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"");
            
            #line 131 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReference.IncludePath));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 132 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 137 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            
            #line 140 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(this.Session.ContainsKey("PackageReferenceList") && this.Session["PackageReferenceList"] != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 145 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        var packageReferenceList = this.Session["PackageReferenceList"] as IList<ProjectFileCreator.PackageReference>;
        foreach(var package in packageReferenceList)
        {

            
            #line default
            #line hidden
            this.Write("    <PackageReference Include=\"");
            
            #line 150 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Include));
            
            #line default
            #line hidden
            this.Write("\" Version=\"");
            
            #line 150 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package.Version));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 151 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 156 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            
            #line 159 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(this.Session.ContainsKey("ServiceDllReferences") && this.Session["ServiceDllReferences"] != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 164 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        var dllReferenceList = this.Session["ServiceDllReferences"] as IList<ProjectFileCreator.Reference>;
        foreach(var reference in dllReferenceList)
        {

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 169 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Name));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <HintPath>");
            
            #line 170 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.HintPath));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>\r\n");
            
            #line 172 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 177 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            
            #line 180 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    if(this.Session.ContainsKey("FrameworkReferences") && this.Session["FrameworkReferences"] != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 185 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        var references = this.Session["FrameworkReferences"] as IEnumerable<ProjectFileCreator.FrameworkReference>;
        foreach(var reference in references)
        {
            if (string.IsNullOrEmpty(reference.HintPath))
            {

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 192 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Name));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 193 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 198 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Name));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <HintPath>");
            
            #line 199 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.HintPath));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>\r\n");
            
            #line 201 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 207 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }
    if(this.Session.ContainsKey("EmbeddedResources") && this.Session["EmbeddedResources"] != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 213 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        var resourceList = this.Session["EmbeddedResources"] as IEnumerable<string>;
        foreach(var resource in resourceList)
        {

            
            #line default
            #line hidden
            this.Write("    <EmbeddedResource Include=\"");
            
            #line 218 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resource));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 219 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 223 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

    if(this.Session.ContainsKey("Services") && this.Session["Services"] != null)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 230 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        var serviceList = this.Session["EmbeddedResources"] as IEnumerable<string>;
        foreach(var service in serviceList)
        {

            
            #line default
            #line hidden
            this.Write("    <Service Include=\"");
            
            #line 235 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(service));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 236 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 240 "C:\dev\CodeBase\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\VS2017ProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class VS2017ProjectFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
