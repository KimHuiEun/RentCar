# Project : RentCar(렌트카 관리 프로그램)

## 개요

고객이 기간 설정 후 차량을 선택하여 렌트하는 기능과 직원의 차량 관리 프로그램을 C# .NET Framework 및 EntityFramework를 이용하여 구현하였다.

## 팀 이름
No.1

## 개발기간
2020년 11월 23일 ~ 2020년 11월 29일

## 참여인원
- IoT기반 스마트팩토리 SW개발 전문가과정
- 김희은, 장석

# 주요기능

## 고객용

### 1. 회원가입 및 로그인

<로그인>

 사용자로 로그인을 하면 로그인, 회원가입 버튼이 사라지고, 로그아웃, 내 정보, 예약조회 버튼이 나옴.  
	내 정보 -> 단위테스트를 진행하여 로그인이 폼에 저장되어 있는지에 대한 체크를 한다. 폼에 들어가면 원래 저장되어있던 데이터가 떠오르게 구현.
  		 수정과 탈퇴가 진행되도록 함. 완료라는 버튼을 누르면 폼이 Close됨
	예약조회 -> 예약했던 DB가 회원id에 부여있으므로 데이터베이스가 뜨게 함.
 
 
 <회원가입>
 
 회원가입폼에서 사용자가 회원가입을 하였을 때 User테이블에 DB가 입력되어야한다.
회원가입폼에는 이름, 전화번호, 이메일, 아이디, 비밀번호, 비밀번호확인, 면허번호, 발급일자가 존재해야하고.
이메일은 null값 허용. 전화번호와 아이디, 면허번호는 이미 존재하는지에 대한 체크를 해야한다.
전화번호, 면허번호는 maskedText, 발급일자는 DateTimePicker 도구를 사용.
완료버튼을 누르면 창이 꺼지고 User테이블에 DB추가.
-사용자는 직접
-관리자는 버튼 클릭시 자동 생성 되도록 만들기 -> 아이디는 manager + 번호 , Admin + 번호 , 비밀번호는 password로 자동부여

검색가능하게 하는 패널이 나오게 함. 차타입과 대여일자와 반납일자에 대해서 검색.(지점은 없애기)
 
### 2. 차량 검색

사용자가 Main폼에서 차크기, 대여일자, 반납일자를 검색하면 나타나는 폼.
폼에 차크기, 대여일자, 반납일자가 자동으로 입력이되지만, 다시 선택이라는 버튼을 넣어 검색을 다시 할 수 있도록 만듦.
검색이 되면 해당되는 리스트화.
필요한 차량에 대해 선택 후 예약이 되게 하는 구현.

### 3. 예약
  
사용자가 예약을 진행하는 폼
예약자 정보랑 차량을 잘 선택했는지 다시 확인할수있음.
확인버튼을 눌렀을 경우 예약이 잘 되었다는 메시지창이 뜨게 하고, 예약확인을 다시 확인할 수 있게 패널을 뜨게 하고 예약취소라는 버튼을 눌러 다시
진행할 수 있도록 함.

 
 
 ## 직원용
 
  매니저와 관리자용 아이디를 부여받은 후 접속
  
  <매니저>
  
  매니저로 로그인을 하면 패널이 떠올라와 세 개의 버튼으로 진행.
 	차량 관리 -> Car테이블 불러오는 패널과 CarType테이블 불러오는 패널을 따로 진행하여 등록, 수정, 삭제, 완료 버튼으로 진행하게 함.
 	회원 관리 -> User테이블을 불러와 등록,수정,삭제,완료 버튼으로 진행하게 함.
 	차트 기입 -> 데이터베이스로 자동 속성 뜨게함.
  
  
  <관리자>
  
  매니저 패널에 한 개의 버튼이 더 추가된 속성.
  직원 관리 -> Admin 테이블을 불러와 등록, 수정, 삭제, 완료 버튼으로 진행하게 함.
  
 
<img src="https://user-images.githubusercontent.com/74526718/100595038-c10fec80-333d-11eb-8fc1-975344a952bb.png" width="400" height="250">
 
<img src="https://user-images.githubusercontent.com/74526718/100595040-c1a88300-333d-11eb-8549-d9a6313f8e11.png" width="400" height="250">  <img src="https://user-images.githubusercontent.com/74526718/100595032-c0775600-333d-11eb-88c3-9f05dca80f42.png" width="400" height="250">
 


# 사용한 기술

## 언어

- C# 8.0

## 프레임워크

- .Net Framework 4.8
- EntityFramework 6.4
- Winform

## 데이터베이스

- MSSQL Server 2019

## 기타개발환경

- Windows10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

## 프로젝트관리
- Github.com (버전 관리용)



# UML

### UseCaseDiagram

<img src="https://user-images.githubusercontent.com/74527086/100572721-8bf1a300-3319-11eb-9f42-ee45f28e6aed.jpg" width="700" height="370">

---

###  전체 프로세스 FlowChartDiagram

<img src="https://user-images.githubusercontent.com/74527286/100579479-a7fc4100-3327-11eb-91b3-0009c8fae2b0.PNG" width="700" height="370">

---

### ClassDiagram 

<img src="https://user-images.githubusercontent.com/74526718/100585213-8a7fa500-3330-11eb-8614-75461b35616f.png" width="900" height="450">

---

### 주요기능 SequenceDiagram

<img src="https://user-images.githubusercontent.com/74527086/100578923-8ea6c500-3326-11eb-954e-843897c020d4.jpg" width="900" height="450">

---


### DB

<img src="https://user-images.githubusercontent.com/74526718/100597015-3d0b3400-3340-11eb-9b43-5349a6c8de24.PNG" width="900" height="450">

- 파일명 : RentCar

- 테이블명 규칙 : 첫글자대문자, 간결성유지.

- 스키마 : 제3 정규화까지 완성함.








# 오류

1.

<img src="https://user-images.githubusercontent.com/74526718/100596029-0680e980-333f-11eb-88a4-afeba396e66d.PNG" width="900" height="450">


해결방안 : Add.config에서 메타데이터에 관한 connectionString="metadata=res: 부분의 서버연결 확인하였음.

<pre><code>
<connectionStrings>
    <add name="RentCarEntities" connectionString="metadata=res://*/RentCar.csdl|res://*/RentCar.ssdl|res://*/RentCar.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=kimpro;initial catalog=_RentCar;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
</code></pre>
  
  
---
 2.
 
 <img src="https://user-images.githubusercontent.com/74526718/100595682-970afa00-333e-11eb-83b3-f1b1296c463e.PNG" width="900" height="450">
 오류 : 주 진입 프로젝트를 중단점으로 몇 개의 코드만 실행했을 때 생기는 디버깅 오류
 
 해결방안 : 디버깅을 할 때의 설정에 내 코드만 되어 있어 외부 코드 참조한 것이 디버깅이 되지 않아 생기는 오류라 설정에서 고쳤다.
 
 https://docs.microsoft.com/ko-kr/visualstudio/debugger/just-my-code?view=vs-2019 참조.

---
3.

<img src="https://user-images.githubusercontent.com/74526718/100595862-d2a5c400-333e-11eb-99ca-26e510fdb213.PNG" width="900" height="450">
오류 : text 파일 읽어들이는 과정에서 오류가 생김. System.Windows.Forms.MaskedTextBox., Text: aa님, 안녕하세요!

해결방안 : 입력된 텍스트를 읽어오는 것이 아니라 텍스트 파일 자체를 읽으려고 했기 때문에. 
     수정 후 
     -Text: aa님, 안녕하세요!

<pre><code>
if(tbLoginId.Text != "admin" && tbLoginId.Text != "manager")
{
     if (user.LoginPw == tbLoginPw.Text)     
     {
           MessageBox.Show(tbLoginId.Text + "님, 안녕하세요!");     ----->원래소스 : textbox 이름인 tbLoginId 를 불러오는 것. 
           this.Close();
     }
     else
     MessageBox.Show("잘못된 비밀번호입니다.");
}
</code></pre>

---
4. 

<img src="https://user-images.githubusercontent.com/74526718/100595951-ef41fc00-333e-11eb-84dd-d4b7e9aa3fef.PNG" width="900" height="450">
오류 : 데이터 엔터티 모델 수정 오류

해결방안 : RentCar.edmx에서 전부 삭제 했다가 데이터베이스 모델 업데이트 하기.

---
5.

<img src="https://user-images.githubusercontent.com/74526718/100595974-fa952780-333e-11eb-853c-4095d358563d.png" width="900" height="450">
오류 : 깃 허브 중복 소스 충돌 해결방안

해결방안 : 소스를 비교하면서 현재 파일을 선택하고 받아들이는 소스 부분부분을 복사 붙여넣기함.

---
6.

오류 : 데이터베이스 저장하려고 DataGridView 사용하였으나 사용법을 모름.

해결방안 : 
<pre><code>
private void CustomerManagement_Load(object sender, EventArgs e)
{
    this.userTableAdapter1.Fill(this._RentCarDataSet1.User);
    this.userTableAdapter.Fill(this._RentCarDataSet.User);
    Clear();
    PopulateDataGridView();
}

private void BtnSave_Click(object sender, EventArgs e)
{
    model.LoginId = TbUserId.Text.Trim();
    model.LoginPw = TbUserPassword.Text.Trim();
    model.Name = TbUserName.Text.Trim();
    model.PhoneNumber = MtbPhoneNumber.Text.Trim();
    model.License = MtbLicense.Text.Trim();
    model.IssueDate = DtIssueDate.CustomFormat.Trim();

    using (RentCarEntities db = new RentCarEntities())
    {
        db.Users.Add(model);
        db.SaveChanges();
    }
    Clear();
    PopulateDataGridView();
    MessageBox.Show("추가되었습니다.");
}

void PopulateDataGridView()
{
    using(RentCarEntities db = new RentCarEntities())
    {
        DgvUser.DataSource = db.Users.ToList<User>();
    }
}
</code></pre>
  
  
---
7.
<img src="https://user-images.githubusercontent.com/74527086/100710308-dd219580-33f2-11eb-9e9b-f81c5ddc6b19.png" width="900" height="450">


오류 : 하나의 프로세스가 진행중에 또 다른 프로세스가 진행되어 오류가 발생하였다.


해결방안 : BackGroundWorker를 사용했더니 UI가 정상적으로 작동하였다.

  
  
  

## 구현 미완성
-Event와 Search의 구현
-관리자 폼에서 매출현황차트와 엑셀 파일 저장
-지점 여러개 만들기
https://github.com/KimHuiEun/RentCar/issues/10#issue-752119211

