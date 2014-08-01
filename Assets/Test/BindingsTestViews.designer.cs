// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;
using UnityEngine;


[DiagramInfoAttribute("BindingsTest")]
public abstract class GameRootElementViewBase : ViewBase {
    
    [UFGroup("TestVMProperty")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _TestVMPropertyPrefab;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _TestProperty;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _TestVMProperty;
    
    public override string DefaultIdentifier {
        get {
            return "GameRootElement";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(GameRootElementViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public GameRootElementViewModel GameRootElement {
        get {
            return ((GameRootElementViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void TestPropertyChanged(string value) {
    }
    
    public virtual void TestVMPropertyChanged(GameSubElementViewModel value) {
        if (value == null && _TestVMProperty != null && _TestVMProperty.gameObject != null) {
            Destroy(_TestVMProperty.gameObject);
        }
        if (_TestVMPropertyPrefab == null ) {
            this._TestVMProperty = ((GameSubElementViewBase)(this.InstantiateView(value)));
        }
        else {
            this._TestVMProperty = ((GameSubElementViewBase)(this.InstantiateView(this._TestVMPropertyPrefab, value)));
        }
    }
    
    public virtual void TestCollectionAdded(string item) {
    }
    
    public virtual void TestCollectionRemoved(string value) {
    }
    
    public virtual void TestVMCollectionAdded(GameSubElementViewBase item) {
    }
    
    public virtual void TestVMCollectionRemoved(GameSubElementViewBase value) {
    }
    
    public virtual ViewBase CreateTestVMCollectionView(GameSubElementViewModel value) {
        return null;
    }
    
    public override void Bind() {
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<GameRootElementController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        GameRootElementViewModel gameRootElement = ((GameRootElementViewModel)(viewModel));
        gameRootElement.TestProperty = this._TestProperty;
        gameRootElement.TestVMProperty = this._TestVMProperty == null ? null : this._TestVMProperty.ViewModelObject as GameSubElementViewModel;
    }
}

[DiagramInfoAttribute("BindingsTest")]
public abstract class GameSubElementViewBase : ViewBase {
    
    public override string DefaultIdentifier {
        get {
            return "GameSubElement";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(GameSubElementViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public GameSubElementViewModel GameSubElement {
        get {
            return ((GameSubElementViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override void Bind() {
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<GameSubElementController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

[DiagramInfoAttribute("BindingsTest")]
public abstract class GameSubDerivedElementViewBase : GameSubElementViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(GameSubDerivedElementViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public GameSubDerivedElementViewModel GameSubDerivedElement {
        get {
            return ((GameSubDerivedElementViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<GameSubDerivedElementController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

[DiagramInfoAttribute("BindingsTest")]
public abstract class Game2RootElementViewBase : GameRootElementViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _DerviedTestProperty;
    
    public override System.Type ViewModelType {
        get {
            return typeof(Game2RootElementViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public Game2RootElementViewModel Game2RootElement {
        get {
            return ((Game2RootElementViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void DerviedTestPropertyChanged(string value) {
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<Game2RootElementController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        Game2RootElementViewModel game2RootElement = ((Game2RootElementViewModel)(viewModel));
        game2RootElement.DerviedTestProperty = this._DerviedTestProperty;
    }
}

public partial class GameRootView : GameRootElementViewBase {
    
    private UnityEngine.Transform _transform;
    
    private UnityEngine.Collider _collider;
    
    [UFToggleGroup("TestProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("TestPropertyChanged")]
    public bool _BindTestProperty;
    
    [UFToggleGroup("TestVMProperty")]
    [UnityEngine.HideInInspector()]
    public bool _BindTestVMProperty;
    
    [UFToggleGroup("TestCollection")]
    [UnityEngine.HideInInspector()]
    public bool _BindTestCollection;
    
    [UFToggleGroup("TestVMCollection")]
    [UnityEngine.HideInInspector()]
    public bool _BindTestVMCollection;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<GameSubElementViewBase> _TestVMCollectionList;
    
    [UFGroup("TestVMCollection")]
    [UnityEngine.HideInInspector()]
    public bool _TestVMCollectionSceneFirst;
    
    [UFGroup("TestVMCollection")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _TestVMCollectionContainer;
    
    public virtual UnityEngine.Transform Transform {
        get {
            if ((this._transform == null)) {
                this._transform = this.GetComponent<UnityEngine.Transform>();
            }
            return this._transform;
        }
    }
    
    public virtual UnityEngine.Collider Collider {
        get {
            if ((this._collider == null)) {
                this._collider = this.GetComponent<UnityEngine.Collider>();
            }
            return this._collider;
        }
    }
    
    protected override void Apply() {
        base.Apply();
        if (Transform.hasChanged) {
            GameRootElement.Position = Transform.position;
            GameRootElement.LocalPosition = Transform.localPosition;
            GameRootElement.Rotation = Transform.rotation;
            GameRootElement.LocalRotation = Transform.localRotation;
            GameRootElement.LocalScale = Transform.localScale;
        }
        GameRootElement.Enabled = Collider.enabled;
        GameRootElement.Dirty = false;
    }
    
    protected override void PreBind() {
        base.PreBind();
        if (this._BindTestProperty) {
            this.BindProperty(()=>GameRootElement._TestPropertyProperty, this.TestPropertyChanged);
        }
        if (this._BindTestVMProperty) {
            this.BindProperty(()=>GameRootElement._TestVMPropertyProperty, this.TestVMPropertyChanged);
        }
        if (this._BindTestCollection) {
            var binding = this.BindCollection(() => GameRootElement._TestCollectionProperty);
            binding.SetAddHandler(TestCollectionAdded);
            binding.SetRemoveHandler(TestCollectionRemoved);
        }
        if (this._BindTestVMCollection) {
            var binding = this.BindToViewCollection(() => GameRootElement._TestVMCollectionProperty);
            if ((_TestVMCollectionContainer == null)) {
            }
            else {
                binding.SetParent(_TestVMCollectionContainer);
            }
            if (_TestVMCollectionSceneFirst) {
                binding.ViewFirst();
            }
            binding.SetAddHandler(item=>TestVMCollectionAdded(item as GameSubElementViewBase));
            binding.SetRemoveHandler(item=>TestVMCollectionRemoved(item as GameSubElementViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreateTestVMCollectionView(viewModel as GameSubElementViewModel); }); ;
        }
    }
}

public partial class GameSubElementView : GameSubElementViewBase {
    
    protected override void Apply() {
        base.Apply();
        GameSubElement.Dirty = false;
    }
    
    protected override void PreBind() {
        base.PreBind();
    }
}

public partial class GameSubDerivedElementView : GameSubDerivedElementViewViewBase {
    
    protected override void Apply() {
        base.Apply();
        GameSubDerivedElement.Dirty = false;
    }
    
    protected override void PreBind() {
        base.PreBind();
    }
}

[DiagramInfoAttribute("BindingsTest")]
public abstract class GameSubDerivedElementViewViewBase : GameSubElementView {
    
    public override System.Type ViewModelType {
        get {
            return typeof(GameSubDerivedElementViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public GameSubDerivedElementViewModel GameSubDerivedElement {
        get {
            return ((GameSubDerivedElementViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<GameSubDerivedElementController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

public partial class Game2RootView : Game2RootViewViewBase {
    
    [UFToggleGroup("DerviedTestProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("DerviedTestPropertyChanged")]
    public bool _BindDerviedTestProperty;
    
    protected override void Apply() {
        base.Apply();
        Game2RootElement.Dirty = false;
    }
    
    protected override void PreBind() {
        base.PreBind();
        if (this._BindDerviedTestProperty) {
            this.BindProperty(()=>Game2RootElement._DerviedTestPropertyProperty, this.DerviedTestPropertyChanged);
        }
    }
}

[DiagramInfoAttribute("BindingsTest")]
public abstract class Game2RootViewViewBase : GameRootView {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _DerviedTestProperty;
    
    public override System.Type ViewModelType {
        get {
            return typeof(Game2RootElementViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public Game2RootElementViewModel Game2RootElement {
        get {
            return ((Game2RootElementViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void DerviedTestPropertyChanged(string value) {
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<Game2RootElementController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        Game2RootElementViewModel game2RootElement = ((Game2RootElementViewModel)(viewModel));
        game2RootElement.DerviedTestProperty = this._DerviedTestProperty;
    }
}