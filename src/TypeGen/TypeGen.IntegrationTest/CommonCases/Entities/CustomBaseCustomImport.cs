﻿using TypeGen.Core.TypeAnnotations;

namespace TypeGen.IntegrationTest.CommonCases.Entities
{
    [ExportTsInterface]
    [TsCustomBase("MB", "./my/base/my-base", "MyBase")]
    public class CustomBaseCustomImport : CustomBaseClass
    {
    }
}
