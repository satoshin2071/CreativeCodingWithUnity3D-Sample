# CreativeCodingWithUnity3D-Sample
SampleCode for [Creative Coding with Unity 3D](https://www.youtube.com/watch?v=7bPQ9L0hvXM&list=PL64OnOdZ_3NGD4qvRucx7BpKUZ-IqGc0Q)

## 各エピソード内容とTips

### 01 : Deconstructing Darkness

**内容**

* 3DCubeを複製し部屋っぽい空間をつくる

**tips**

* `Prefrences → PlayMode tint` をビビッドにして再生中をわかりやすく
* `Window → Lighting` はInsepectorの隣のタブにしておくと作業が楽
* `Lighting → scene → skybox none`でskyboxを表示させたくない
* `GameObject → AlignWithView` でMainCameraの位置をサクッと動かす
* `GameObject　→ AlignViewToSelected　` → でMainCameraの位置に戻る

### 02 : Let There be Light

**内容**

* pointLightの使い方
* 壁にテクスチャを使って色を設定する
* テクスチャのEmissionを使って壁を発光させる

**tips**

* SF映画風の照明効果
	* MainCameraのAmbientColorっぽく極薄い緑に
	* pointLightは薄い黄色に
	* 参考 [映画製作者が「色」で観客の心情を操作する方法とは？](http://gigazine.net/news/20151013-filmmakers-manipulate-emotion/)
* 部屋空間の壁は位置が固定されているので `inspector → static`をチェック
	* staticにすることで自動的にライトマップの焼きこみが発生
	* 参考 [http://tsubakit1.hateblo.jp/entry/2015/03/10/030139#ライトを焼く](http://tsubakit1.hateblo.jp/entry/2015/03/10/030139#ライトを焼く)

### 03 : It's Alive!

**内容**

* c#スクリプトで動きを制御する
	* 回転させる
	* ポジションを設定する
	* ランダムな速度にする

### 04 : Spinning on that Dizzy Edge

**内容**

* transform.RotateAround(point,axis,angle)で3DCubeを周回させる
* ここまで作成した3DCubeをPrefab化する

**メモ**

* transform.RotateAround(point,axis,angle)
	* ワールド座標`point`を中心とした軸`axis`で`angle`度傾けながら回転させる
	* axisが `new Vector3 (1,0,0)`ならx軸まわりの回転
	* axisが `new Vector3 (0,1,0)`ならy軸まわりの回転
	* axisが `new Vector3 (0,0,z)`ならz軸まわりの回転

### 05 : Absolutely (Pre)Fabulous!

**内容**

* Prefab化したCubeをInstantiateしてスクリプト内で生成する
* GetComponentでCubeに設定されているPublicなPropertyにアクセスする
* Cubeを複数個生成する

### 06 : SIN() City

**内容**

* Mathf.Sinを利用して3DCubeのX座標のを調整する
* 複数生成した3DCubeが良い塩梅の間隔で並ばせる

**tips**

Mathf.Sin(Mathf.PI/2)を利用して3DCubeのx座標を良い塩梅の間隔にする

```
for (int i = 0; i < totalCubes; i++) {
	float perc = i / (float)totalCubes;
	float sin = Mathf.Sin(perc * Mathf.PI/2);
	float x = 1.8f + sin * totalDistance;
```

* 参考リンク [Interactive Unit Circle](https://www.mathsisfun.com/algebra/trig-interactive-unit-circle.html)

### 07 : Some Light Probing

**内容**

* `LightProbe`を利用して pointLightを2つ追加することなく照明の効果をゲームオブジェクトに反映させる

**tips**

* 基本照明や影の効果はパワー使うので多すぎないように
* [LightProbes リファレンス](http://docs.unity3d.com/Manual/LightProbes.html)
* 対象のGameObjectの`Inspector → Mesh Renderer → Use Light Probs`のチェックがついていることを確認

### 08 : Ready For My Close Up


**内容**

* `StandardAssets Effect` を利用してMainCameraに効果を追加する
	* Depth of Field でボケさせる
	* Bloom で発光させる

**tips**

上記2つのEffectはPlay中にInspectorの値を調整することで設定すると作業が楽

