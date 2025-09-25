
# **開頭**

# 佳凌科技內部程式庫: Calin.xxx

## 專案定義

- 程式庫的專案名稱均以 `Calin.` 開頭。
- 預設情況下 (創建程式庫時即以 `Calin.` 開頭)，組件名稱 (AssemblyName) 及命名空間 (namespace) 都也會以 `Calin.` 開頭，若不是請在專案屬性中修改 (見後面 *專案屬性設定*)。

## 新增 x86 平台

為配合各單位電腦的等級，方案平台的組態需新增 `x86` 項目，不論使用 Debug 或 Release 編譯，均更改為 `x86` 組態再編譯。

---

# **中間段**

## **.NET Standand 類別庫版**

## 專案屬性設定

- 應用程式
	- 一般
		- 輸出類型
			- `類別庫`
		- 目標 Framework
			- `.NET Framework 2.0`
	- 建置
		- 一般
			- 平台目標
				- `x86`
			- 輸出
				- 打勾
					- `參考組件`、`文件檔案`
	- 套件
		- 一般
			- 打勾
				- `在建置時產生 NuGet 套件`
		- 套件識別碼 (PackageId)
			- 原則上不變更。
			- PackageId 即為預設的組件名稱 (AssemblyName) 與預設的命名空間 (namespace)。
			- 參考資料: [套件撰寫最佳做法](https://learn.microsoft.com/zh-tw/nuget/create-packages/package-authoring-best-practices)。
		- 職稱 (Title)
			- 給人看的，對專案設定額外的名稱，依需求輸入。
		- 套件版本
			- 請見下節，建議配合 CHANGELOG.md 一起修改。
		- 作者
			- `佳凌科技股份有限公司 Calin Technology Co.,Ltd.`
		- 公司
			- `佳凌科技股份有限公司 Calin Technology Co.,Ltd.`
		- 說明
			- 依需求填寫。
		- 著作權
			- `Copyright © 2025 Calin Technology Co.,Ltd.`
		- 讀我檔案 (本檔)
			- `README.md`
		- 組件中性語言
			- 目前的程式庫沒有要做多語言版本，故暫不變更。
		- 組件版本、檔案版本
			- 請見下節 *版本號的約定方式*，則上依預設值，但有需要也可變更。
	- 授權
		- 目前還不確定公司內部程式庫的授權方式，暫不設定。

## **WinForm 類別庫版**

## 專案屬性設定

- 應用程式
	- 組件名稱 (AssemblyName) 和預設命名空間 (namespace)
		- 原則上不動，但可需要更改，要以 `.Calin` 開頭。
	- 輸出類型
		- `類別庫`
	- 目標 Framework
		- `.NET Framework 4.6.2`
	- 組件資訊
		- 公司
			- `佳凌科技股份有限公司 Calin Technology Co.,Ltd.`
		- 著作權
			- `Copyright © 2025 Calin Technology Co.,Ltd.`
		- 組件中性語言
			- 目前的程式庫沒有要做多語言版本，故暫不變更。
		- 組件版本、檔案版本
			- 請見下節 *版本號的約定方式*，原則上依預設值，但有需要也可變更。
		- 其餘欄位依需要變更。
- 建置
	- 平台目標
		- `x86`
	- 打勾
		- `XML 文件檔案`

---

# **結尾**

## 程式庫版本號的約定方式

- VS 內的版本設定，有套件版本、組件版本、檔案版本...等，其意義參見 [版本控制](https://learn.microsoft.com/zh-tw/dotnet/standard/library-guidance/versioning)。
- 版本號以三部分表示：`主版本號`.`次版本號`.`修訂號` (`MAJOR`.`MINOR`.`PATCH`)，==採用 X.Y.Z 的格式==，其中 X、Y 和 Z 為非負的整數，且禁止（MUST NOT）在數字前方補零，最好使用 [語意版本設定 (SemVer)](https://semver.org/lang/zh-TW/) 來更新它。以下節錄部分建議事項：
	- 主版本號表示不相容的 API 更改，次版本號表示向後相容的功能性新增，修訂號則表示向後相容的問題修正。
	- 標記版號的軟體發行後，禁止（MUST NOT）改變該版本軟體的內容。任何修改都必須（MUST）以新版本發行。
	  註：==建議在版本功能完成並編譯後，即增加一版修訂號==，保留原本穩定運行的原始碼，避免公共區域發生變故。
	- 修訂號 Z（x.y.Z | x > 0）必須（MUST）在只做了向下相容的修正時才遞增。這裡的修正指的是針對不正確結果而進行的內部修改。
	- 次版號 Y（x.Y.z | x > 0）必須（MUST）在有向下相容的新功能出現時遞增。在任何公共 API 的功能被標記為棄用時也必須（MUST）遞增。也可以（MAY）在內部程式有大量新功能或改進被加入時遞增，其中可以（MAY）包括修訂級別的改變。每當次版號遞增時，修訂號必須（MUST）歸零。
	- 主版本號 X（X.y.z | X > 0）必須（MUST）在有任何不相容的修改被加入公共 API 時遞增。其中可以（MAY）包括次版號及修訂級別的改變。每當主版號遞增時，次版號和修訂號必須（MUST）歸零。

## **.NET Standard 類別庫版**

### 上傳 NuGet 套件

因為公司內沒有 NuGet 伺服器，也沒有版控環境，所以請自行將 Release 版本的 `方案名.x.y.z.nupkg` 檔複製到公共區域。(以下均以某個叫做 `CalinSharedLibrary` 的資料夾為例子)

### 應用程式要使用本程式庫時的方法

1. 新增 NuGet 套件來源。
	- 有兩種方法開啟套件管理員 (VS2022)：
		1. 工具 -> NuGet 套件管理員 -> 套件管理員設定
		2. 工具 -> 選項 -> NuGet 套件管理員
	- 在套件來源分頁中，按右上角 `綠色＋`，列表中會新增一個 Package Source。
	- 點選 Package Source 後，在最下方更改資訊：
		- 名稱: 通常與公共資料夾同名，這裡為 `CalinSharedLibrary`。
		- 來源: 按 `...` 開啟檔案總管，點選 CalinSharedLibrary 資料夾後按 `選取`。
	- 按 `更新`，確認列表的資訊已變更為正確的 CalinSharedLibrary 位置。
	- 都正確後按 `確定`。
2. 在應用程式的方案或專案中，右鍵選擇 `管理 NuGet 套件`，將右上角的套件來源變更為 `CalinSharedLibrary`，即可看見編譯好的 NuGet 套件。

## **WinForm 類別庫版**

### 上傳 .dll 檔

- .NET Framework 類別庫 **沒有**「產生 NuGet 套件」的選項，那更別說也沒有 .NET Framework 版本的 Windows Form 類別庫。
- 網路上方法有很多，但幾乎都需要網管的權限。為避免麻煩，採用參考 .dll 檔的方式。
- 請自行將 Release 版本的 `方案名.dll` 檔複製到公共區域。(以下均以某個叫做 `CalinSharedLibrary` 的資料夾為例子)

### 應用程式要使用本程式庫時的方法

1. 方案總管中，在要引用的專案上按 `右鍵`->`加入`->`參考`，打開參考管理員。
2. 若專案頁上沒有要引用的 .dll 檔，按 `瀏覽`，到 `CalinSharedLibrary` 資料夾點選該 .dll 檔，按 `確定` 將其引用即可。
