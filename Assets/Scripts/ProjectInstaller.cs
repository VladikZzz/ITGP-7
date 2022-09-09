using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectInstaller : MonoInstaller
{
    public override void InstallBindings(Container container)
    {
        container.BindSingleton&lt;int&gt;(42);
        container.Bind&lt;IDependencyOne&gt;().To&lt;DependencyOne&gt;().AsTransient();
        container.Bind&lt;IDependencyTwo&gt;().To&lt;DependencyTwo&gt;().AsSingletonLazy();
        container.BindGenericContract(typeof(SetupAsset&lt&gt)).To(
            typeof(SetupEnemy),
            typeof(SetupLevel)
        ).AsSingletonNonLazy();
    }
}
