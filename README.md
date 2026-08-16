<h1># ASP.NET-Core-8_1st-</h1>
<p>ASP.NET Core 8 + C# 練習_作品集</p>
<h2>自學 C# 與 ASP.NET Core 8 with Visual Studio (從 0 開始)</h2>
<br>Language：C#</br>
<br>Platform：ASP.NET Core 8</br>
<br>IDE：Visual Studio</br>

<b><h1>階段進程</h1></b>
## 各階段目標分配
> [!NOTE]
>* 1. 創立一個空白 MVC 專案，M-V-C 全手工刻入程式碼
>* 2. STAGE 1 ：Models 建立（資料架構） -  定義這個資料是甚麼樣子
>* 3. STAGE 2 ：DataBase 建立（EF Core - DbContext）- 使 Model 對應到實際的資料表
>* 4. STAGE 3 ：Controllers 建立 (後端-控制器) - 邏輯 - 去操作資料
>* 5. STAGE 4 ：Views 建立（前端）- 將資料呈現出來
>* 6. STAGE 5 ：測試執行 TEST - 測試WEB是否可以正常顯示且更新資料表

## 學習紀錄
<h2>0816</h2>
<ul>
  <li><b>使用 Visual Studio 建立新的專案</b></li>
  <li><b>選擇＂空的 ASP.NET Core＂ 專案範本</b></li>
    <img width="1008" height="891" alt="image" src="https://github.com/user-attachments/assets/5891f9da-0065-4179-b4d0-7621b159f614" />
  <li><b>初始畫面如下：</b></li>
    <img width="1917" height="964" alt="image" src="https://github.com/user-attachments/assets/1d8c3af4-f5af-4e8d-8874-fd88a0e93ebf" />
    <li>Connected Services</li><text>目前還不知道作用是甚麼</text>
    <li>Properties</li><text>目前還不知道作用是甚麼</text>
    <li>相依性</li><text>目前還不知道作用是甚麼</text>
    <li>appsettings.json</li><text>還沒有完全搞清楚要做甚麼用的</text>
    <li>Program.cs</li><text>(整個專案的關聯方式嗎 不曉得)</text>
    <li>Models</li><text>建立規格資料架構</text>
    <li>Data</li><text>資料庫的建立-需求檔案</text>
    <li>Controllers</li><text>建立控制(使用) Models 的控制器</text>
    <li>Views</li><text>簡白而言,就是網站的長相 VIEW </text>
</ul>

### STAGE 1 : 建立Models
<ul>
  <li><b>建立Models資料夾噢.cs檔案 for items</b></li>
  <img width="1917" height="629" alt="image" src="https://github.com/user-attachments/assets/51400003-5e17-4e58-87dc-89e244848641" />
</ul>
  <img width="427" height="225" alt="image" src="https://github.com/user-attachments/assets/dcd301ad-5b45-4fff-b10b-285bf03960a1" />
  
  *修正 NOTE*

### STAGE 2 : 建立 DataBase
<ul>
  <li>這個階段涵括兩個項目需要執行（Claude說的）</li>
    - 選擇預計使用的 <b>SQL Server</b>
    - 建立 DbContext Class
  
</ul>
