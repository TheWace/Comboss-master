// <copyright file="BoostTest.cs">Copyright ©  2017</copyright>
using System;
using Comboss;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Comboss.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour Boost</summary>
    [PexClass(typeof(Boost))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BoostTest
    {
        /// <summary>Stub de test pour getDamage()</summary>
        [PexMethod]
        internal float getDamageTest([PexAssumeUnderTest]Boost target)
        {
            float result = target.getDamage();
            return result;
            // TODO: ajouter des assertions à méthode BoostTest.getDamageTest(Boost)
        }

        /// <summary>Stub de test pour getElement()</summary>
        [PexMethod]
        internal Element getElementTest([PexAssumeUnderTest]Boost target)
        {
            Element result = target.getElement();
            return result;
            // TODO: ajouter des assertions à méthode BoostTest.getElementTest(Boost)
        }
    }
}
