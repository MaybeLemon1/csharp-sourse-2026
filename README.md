# C# Course 2026

폴리텍 2학기 C# 프로젝트 저장소입니다. 일자별로 독립된 프로젝트를 추가하고, 하나의 솔루션에서 관리합니다.

## 프로젝트 구조

```text
csharp-course-2026/           # Git Root
├── .gitignore                # C# / Rider 전용 ignore 파일
├── README.md                 # 프로젝트 구조 및 프로젝트 추가 방법
├── csharp-course-2026.sln    # 현재 저장소의 솔루션 파일
│
├── Day01_OOP_Review/         # 1일차: OOP 복습
│   ├── Day01_OOP_Review.csproj
│   └── Program.cs
│
├── Day02_Properties/         # 2일차: 프로퍼티 및 캡슐화
│   ├── Day02_Properties.csproj
│   └── Program.cs
│
├── Day03_Inheritance/        # 3일차: 상속과 다형성
│   ├── Day03_Inheritance.csproj
│   └── Program.cs
│
└── CommonUtils/              # 선택 사항: 공통 라이브러리
    ├── CommonUtils.csproj
    └── Helper.cs
```

새로운 수업 프로젝트는 `Day04_주제명`처럼 일자와 주제를 조합해 이름을 정합니다.

## Rider에서 프로젝트 추가하기

1. Rider에서 `csharp-course-2026.sln`을 엽니다.
2. 솔루션 창에서 솔루션을 마우스 오른쪽 버튼으로 클릭합니다.
3. `Add` → `New Project`를 선택합니다.
4. `Console Application`을 선택합니다.
5. 프로젝트 이름을 입력합니다. 예: `Day04_Interfaces` (`Do not use top-level statements`를 선택)
6. 저장 위치가 저장소 루트인지 확인합니다.
7. 대상 프레임워크를 기존 프로젝트와 동일하게 선택합니다.
8. `Do not use top-level statements` 옵션을 체크합니다.
9. `Create`를 클릭합니다.
10. 솔루션에 새 프로젝트가 추가되었는지 확인합니다.
11. `Program.cs`에서 수업 코드와 과제 코드를 작성합니다.

## dotnet CLI로 프로젝트 추가하기

```bash
dotnet new console -o Day04_Interfaces --use-program-main
dotnet sln csharp-course-2026.sln add Day04_Interfaces/Day04_Interfaces.csproj
```