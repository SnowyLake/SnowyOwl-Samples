# SnowyOwl Samples Agent Guide

## 目录

- [项目定位](#项目定位)
- [依赖关系](#依赖关系)
- [资源边界](#资源边界)
- [验证入口](#验证入口)

## 项目定位

- 本仓库是 SnowyOwl GraphicsFramework 的 Unity 示例与集成验证工程, Unity 版本固定为 `2022.3.62f3`.
- 框架实现在独立的 SnowyOwl GraphicsFramework 仓库中维护, 本仓库只保存示例, 项目配置和验证资源.

## 依赖关系

- `Packages/manifest.json` 引用框架, CoreRP 和 URP 三个本地 package.
- 三个本地依赖必须指向同一个 GraphicsFramework 工作副本, 不要将其中一个替换为 registry 或 Git 版本.

## 资源边界

- `Assets/SnowyOwlLocal/` 保存本工程使用的渲染管线与全局配置资源.
- `Assets/SharedAssets/SharedAssets/Scenes/` 保存主要框架验证场景.
- `Assets/UrpExampleAssets/` 保存 URP 示例内容, 与框架验证资源分开维护.
- 不要提交 Unity 生成目录, IDE 工程文件或本机安装的商业插件.

## 验证入口

- 修改项目配置或资源后, 先确认 Unity 完成导入且 Console 无新增错误.
- 框架改动至少验证受影响功能的代表场景.
- 资源移动, 重命名或删除时保持对应 `.meta` 文件和 GUID 关系.
