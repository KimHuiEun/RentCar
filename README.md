# Project : RentCar

## 개요
고객이 기간과 차 모델을 검색후 빌리고 싶은 차량을 렌트하는 프로그램 구현.


## 개발기간
2020년 11월 23일 ~ 2020년 11월 29일

## 참여인원
김희은, 장석, 박찬영


# 사용한 기술

## 언어

C# 8.0

## 프레임워크

.Net Framework 4.8
EntityFramework 6.4
Winform

## 데이터베이스

MSSQL Server 2019

## 기타개발환경

Windows10
Microsoft Visual Studio Community 2019 v16.8
Microsoft SQL Server Management Studio v18.6

-----------------------------------


# 다이어그램
<img src="https://user-images.githubusercontent.com/74527086/100572721-8bf1a300-3319-11eb-9f42-ee45f28e6aed.jpg" width="700" height="370">

---

<img src="https://user-images.githubusercontent.com/74527286/100579479-a7fc4100-3327-11eb-91b3-0009c8fae2b0.PNG" width="700" height="370">

---

<img src="https://user-images.githubusercontent.com/74527086/100578923-8ea6c500-3326-11eb-954e-843897c020d4.jpg" width="700" height="370">

---


### DB

-서버 : kimpro

-파일명 : RentCar

-테이블명 규칙 : 첫글자대문자, 간결성유지.

-Rent(Main) ---연결---User, Car

-User (= Account) ---연결---Event

-Event

-Car ---연결--- CarType, IsRent의 변수로 렌트중인지아닌지 구분(bit)

-CarType

-Admin ---연결--- User, Car

-Search ---연결--- User, CarType


### visual studio C#

-C:git

-솔루션이름 : CarRentalManagementSystem

-프로젝트 이름 : CarRent, CarRent.Data, CarRent.UnitTest

### CarRent의 폼.

-Login

-Account

-Selection

-Payment

-Customer

-Manager

-Admin

---------------------------------------------------

                              
                                       
                                



--------------------------------------------------------
#구현
구현 완성
-스키마 : 제3 정규화까지 완성함.


구현 미완성
-Event와 Search의 구현
-관리자 폼에서 매출현황차트와 엑셀 파일 저장
-지점 여러개 만들기
https://github.com/KimHuiEun/RentCar/issues/10#issue-752119211

----------------------------------------------------------
#오류

1. 
[

오류: App.config에 MSSM과 연결 관계에 대한 문구를 넣지 않음.

해결방안 : <connectionStrings>
    <add name="RentCarEntities" connectionString="metadata=res://*/RentCar.csdl|res://*/RentCar.ssdl|res://*/RentCar.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=kimpro;initial catalog=_RentCar;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
  
  
  
  
 2.
 
 오류 : 주 진입 프로젝트를 중단점으로 몇 개의 코드만 실행했을 때 생기는 디버깅 오류
 
 해결방안 : 디버깅을 할 때의 설정에 내 코드만 되어 있어 외부 코드 참조한 것이 디버깅이 되지 않아 생기는 오류라 설정에서 고쳤다.
 
 https://docs.microsoft.com/ko-kr/visualstudio/debugger/just-my-code?view=vs-2019 참조.


3.
오류 : text 파일 읽어들이는 과정에서 오류가 생김. System.Windows.Forms.MaskedTextBox., Text: aa님, 안녕하세요!

해결방안 : 입력된 텍스트를 읽어오는 것이 아니라 텍스트 파일 자체를 읽으려고 했기 때문에. 
     수정 후 
     -Text: aa님, 안녕하세요!

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


4. 
오류 : 데이터 엔터티 모델 수정 오류

해결방안 : RentCar.edmx에서 전부 삭제 했다가 데이터베이스 모델 업데이트 하기.


5.
오류 : 깃 허브 중복 소스 충돌 해결방안

해결방안 : 소스를 비교하면서 현재 파일을 선택하고 받아들이는 소스 부분부분을 복사 붙여넣기함.


6.
오류 : 메타데이터 파일 오류

해결방안 : Add.config에서 메타데이터에 관한 connectionString="metadata=res: 부분의 서버연결 확인하였음.
<connectionStrings>
    <add name="RentCarEntities" connectionString="metadata=res://*/RentCar.csdl|res://*/RentCar.ssdl|res://*/RentCar.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=kimpro;initial catalog=_RentCar;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>


7.
오류 : 데이터베이스 저장하려고 DataGridView 사용하였으나 사용법을 모름.

해결방안 : 
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
'''
void PopulateDataGridView()
{
    using(RentCarEntities db = new RentCarEntities())
    {
        DgvUser.DataSource = db.Users.ToList<User>();
    }
}
'''
  
  
  
  
  ThreeRentCar : 렌트카 관리 프로그램
개요
고객이 기간 설정 후 차량을 선택하여 렌트하는 기능과 직원의 차량 관리 프로그램을 C# .NET Framework 및 EntityFramework를 이용하여 구현하였다.


개발 기간
2020년 11월 23일 ~ 2020년 11월 29일




#언어
C# 8.0

#프레임워크
.Net Framework 4.8
EntityFramework 6.4
Winform

#데이터베이스
MSSQL Server 2019

#기타 개발환경
windows 10
Microsoft Visual Studio Community 2019 v16.8
Microsoft SQL Server Management Studio v18.6


다이어그램

1. use case Diagram






2. Class Diagram





3. FlowChart Diagram





4. Sequence Diagram



 






직원용 프로그램
1. 직원 로그인
 
확인 버튼을 누르면 정보가 입력되었는지 판단하고 다음 창으로 넘어간다.
2. 작업 선택

 
직급 별로 선택이 가능한 작업이 달라진다.
선택이 불가능한 직업의 버튼은 색상이 변한다.
3. 문진표 관리

 
선택된 문진표의 열람 및 진단서 작성이 가능하다
선택된 문진표의 삭제가 가능하다
4. 문진표 질문 관리

 
문진표 질문의 추가, 수정, 삭제가 가능하다
질문의 문항 유형은 주관식, 객관식, 객관석(다중선택)이다
수정 후 일괄저장버튼을 눌러야 데이터베이스에 저장된다
5. 환자 정보 관리
 
선택된 환자의 정보 수정 및 삭제가 가능하다
이름별 검색이 가능하다
6. 직원 정보 관리

 
직원의 추가가 가능하다. 직원 추가 시 비밀번호는 초기값(password)으로 자동 저장된다
선택된 직원의 수정 및 삭제가 가능하다
이름별 검색이 가능하다
관리 항목
1. 고객 정보
문진표를 작성한 고객의 정보를 확인할 수 있다. 또한, 고객 정보의 수정 및 삭제가 가능하다.
고객 정보를 삭제하게 되면 고객이 작성했던 문진표의 정보도 같이 삭제된다.
2. 직원 정보
직원들의 정보를 확인할 수 있다. 개인 정보를 포함한 직급 정보와 진료과 정보를 확인할 수 있다.
직원의 추가 및 수정, 삭제가 가능하다.
3. 문진표 정보
작성된 문진표의 정보를 확인할 수 있다. 문진표의 정보는 진료과, 작성 일자 및 작성한 고객의 정보로 이루어져 있다.
문진표의 열람 및 삭제가 가능하며, 의사와 병원장의 경우에는 진단 내용 작성이 가능하다.
4. 문진표 질문 정보
문진표 질문 정보를 진료과별로 확인할 수 있다.
문진표의 질문 추가, 수정, 삭제가 가능하다.
사용 기술
언어
C# 3.0+
프레임워크
.Net FrameWork 4.8
EntityFrameWork 6.2
Winform
데이터베이스
MSSQL Server 2019
기타 개발환경
Windows 10
Microsoft Visual Studio Community 2019 v16.8
Microsoft SQL Server Management Studio v18.6
데이터베이스 스키마
스키마

모든 항목이 제 3 정규화까지 완료됐다
순서도
1. 고객용 프로그램
고객용 다이어그램

2. 직원용 프로그램
직원용 다이어그램

Point of Interest
DB 테이블의 속성 변경 등 업데이트 내역이 EntityFramework에 반영되지 않은 문제 #24
증상
문진표 저장을 누를 시 에러 발생
원인
EntityFramework로 불러온 데이터베이스의 문진표 테이블 PK컬럼의 IDENTITY_INSERT 속성이 OFF로 되어있었다
결과
처음에는 DB에 있는 문진표 테이블 PK컬럼의 IDENTITY_INSERT 속성을 ON으로 변경했다. 하지만 같은 오류가 발생했다.
확인 결과, 처음에 DB 스키마 설계 시 테이블 PK에 IDENTITY_INSERT 속성을 ON으로 바꾸지 않았고, 그 상태로 EntityFramework로 불러와, EntityFramework상에는 IDENTITY_INSERT 속성이 OFF로 저장되어 있었다.
그래서, EntityFramework 다이어그램에서 우클릭으로 제공하는 '데이터베이스에서 모델 업데이트'메뉴를 실행, 업데이트 마법사를 이용해 DB의 정보를 업데이트하여 문제를 해결함 update
외래키로 연결된 여러 테이블의 값을 동시에 삽입하는 트랜잭션 진행중에 에러가 발생하는 문제 #24
증상
새로운 Customer(환자)가 문진표를 입력하면, 에러가 발생
원인
신규 환자가 문진표 입력이 완료되면 Customer(고객), Questionnare(문진표), Response(문진표응답) 총 3개의 테이블에 데이터가 삽입되는데, 이 때 신규 환자는 등록 전에는 CustomerID가 없어, Customer테이블에서 키값의 최대값을 가져와 등록했는데 이 값이 실제 IDENTITY 컬럼을 통해 저장되는 내용과 맞지 않아 오류가 발생했다
여러 테이블의 데이터가 동시에 저장되는 트랜잭션을 끊지 않고 IDENTITY 컬럼의 값을 미리 구해서 저장하거나 다른 방법이 필요했다.
결과
처음에는 C#에서 IDENTITY 컬럼의 값을 구하는 법을 찾고 있었는데, 검색 하던 도중 다른 방법을 발견했다
EF가 ID값을 찾아 할당하는 것이 아니라 테이블 개체 자체를 할당하는 기능을 지원하며, EF로 생성된 Entity 모델에 생성되어 있는 외래키로 연결된 하위 모델을 이용해 연결할 수 있다는 것을 알게 되었다.
그래서 Entity 모델의 개체를 생성할 때 상위 테이블 개체를 연결해주면, 한번에 SaveChange를 진행해도 Insert된 개체에 대해 자동으로 ID키가 연결되어 에러가 발생하지 않고 트랜젝션도 깨지지 않게 된다.
그래서 개체를 생성할 때, 상위 테이블 개체를 연결해주는 작업을 진행했다.
public Questionnare CreateQuestionnare { get; set; }

// before
CreateQuestionnare = new Questionnare();
// after
CreatedQuestionnare = new Questionnare { Customer = ConnectedCustomer };
포커스 변화에 따라 강제로 스크롤이 조절되는 문제 #26
증상
"입력완료"버튼을 누르면 패널 컨트롤의 스크롤이 맨 위로 올라가는 현상
원인
확인 결과, 휠 스크롤이나 다른 행동을 한 이후 패널 컨트롤 내에 있는 다른 컨트롤을 클릭하여 Focus가 되면, 패널 컨트롤이 ActiveControl로 간주가 되어 어떤 경로를 통해ScrollableControl.ScrollToControl 메서드가 실행되고 스크롤 위치가 강제로 옮겨지는 것으로 판단된다.
결과
ScrollToControl이 가상 메서드이기 때문에, 패널 컨트롤을 상속받는 CustomPanel클래스를 만들고 ScrollToControl 메서드를 오버라이드하여 우리가 원하는 동작을 하도록 수정하여 해결
문제를 해결하긴 했지만, 정확하게 ScrollToControl이 어떤 원리로 동작하는지와 패널과 스크롤의 상관관계를 정확하기 이해하지는 못함
public class CustomPanel : System.Windows.Forms.Panel
{
    protected override System.Drawing.Point ScrollToControl(System.Windows.Forms.Control activeControl)
    {
        // Returning the current location prevents the panel from
        // scrolling to the active control when the panel loses and regains focus
        return this.DisplayRectangle.Location;
    }
}
출처 https://blog.naver.com/raon_pgm/150185087803 https://nickstips.wordpress.com/2010/03/03/c-panel-resets-scroll-position-after-focus-is-lost-and-regained/
클래스 단위로 데이터 관리 중 얕은 복사로 인해 데이터의 손실이 일어난 문제 #61
증상
문진표 문제 관리에서 문제를 중간에 추가하거나, 문제의 위치를 수정하는 등의 위치 변경 작업이 진행될 때, 변경된 문제로 인해 함께 변경되는 다른 문제들의 인덱스가 비정상적으로 변하는 문제
원인
문진표 문제 관리를 데이터가 변경될 때 마다 데이터베이스로 직접 연결해 변경하는 것이 아니라, 프로그램 내 객체로 관리를 하다보니 자연스럽게 클래스(Entity)단위로 관리를 하게 되는데, 클래스가 참조 타입이기 때문에 데이터를 복사하여 추가하는 과정에서 '얕은 복사'가 발생해 데이터 변경 로직이 꼬였다.
결과
데이터를 복사해 수정하는 부분 중 개체가 '복사'되는 부분에서 '깊은 복사'기능을 구현하여 적용하여 해결했다
깊은 복사 기능은 EF로 생성된 Entity 클래스를 Patial클래스로 다른곳에서 작업하여 깊은 복사 기능(메서드)을 만들어 해결했다.
깊은 복사 기능을 하는 Clone메서드를 만들때는 C#에서 제공하는 ICloneable 인터페이스를 상속하여 작업했다.
public partial class Question : ICloneable
{
    public object Clone()
    {
        Question question = new Question();
        // ...
        return question;
    }
}
// before
Question question = AfterQuestions.FindAll(x => x.Index == i)
    .OrderByDescending(x => x.Version)
    .FirstOrDefault();
question.Index++;

// after
var data = AfterQuestions.FindAll(x => x.Index == i)
    .OrderByDescending(x => x.Version)
    .FirstOrDefault();
Question question = (Question)data.Clone();
question.Index++;
간헐적으로 접속중인 직원의 정보가 사라지는 문제 #74
증상
접속하여 작업 후 다른 id로 로그인 시 간헐적으로 오류 발생
원인
진단 내용 작성 폼에 전달된 접속중인 직원의 ID값이 null로 됨
원인을 찾던 중, 문진표 관리 뒤로가기 버튼 이벤트 활성 시 접속중인 직원의 정보가 전달이 되지 않는 문제를 발견
결과
문진표 관리 뒤로가기 버튼 이벤트 활성 시, 이벤트 핸들러를 통해 접속중인 직원의 정보가 전달되도록 변경함. 또한, 문진표 질문 관리, 직원 관리, 고객 관리의 각 버튼 이벤트 핸들러 구문에 접속중인 직원의 정보가 전달되도록 수정
문제의 발생 빈도와 조건이 정확하게 규명되지 않은 문제이므로, 적용된 솔루션을 통해 해당 문제가 완전히 해결되었다고 단언할 수 없음. 추가 테스트를 통해 해당 오류 발견시 조치 필요
// before
private void btnGoBack_Click(object sender, EventArgs e)
{
    EmployeeSelectFunctionControl employeeSelectFunctionControl = 
        new EmployeeSelectFunctionControl();
    OnbtnCancelClicked(employeeSelectFunctionControl);
}

// after
private void btnGoBack_Click(object sender, EventArgs e)
{
    EmployeeSelectFunctionControl employeeSelectFunctionControl = 
        new EmployeeSelectFunctionControl(currentEmployeeInHere);
    OnbtnCancelClicked(employeeSelectFunctionControl);
}
