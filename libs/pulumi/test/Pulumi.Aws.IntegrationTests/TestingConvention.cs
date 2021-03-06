﻿using Fixie;

namespace Logicality.Pulumi.Aws
{
    public class TestingConvention: Discovery
    {
        public TestingConvention()
        {
            Classes.Where(t => t.Name.EndsWith("Tests"));

            Methods.Where(t => t.IsPublic && !t.IsStatic);
        }
    }
}
