通过实现自定义策略授权模式，实现了 AuthorizationHandler：
   PermissionRequirement
   PermissionRequirementHandler，内部通过 IPermissionChecker 进行权限检查。
   在 PermissionChecker 实现中，
   通过 “PermissionDefinitionManager” 获取 “PermissionDefinition”
   通过 “PermissionValueProviders”  对 获得的权限进行检查,
   只要有一个 “PermissionValueProviders” 检查通过，则满足条件。


PermissionDefinitionManager 如何初始化系统的 Permission：
    PermissionDefinitionManager作用：提供系统定义的 权限信息。
    abp 将权限按Group划分，具体两个类为：PermissionGroupDefinition， PermissionDefinition，他们是Abp对“权限”的描述。

    
	
   
