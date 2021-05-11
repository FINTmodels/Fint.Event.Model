pipeline {
  agent {
    docker {
      label 'docker'
      image 'microsoft/dotnet'
    }
  }
  stages {
    stage('Build') {
      steps {
        sh 'git clean -fdx'
        sh 'dotnet msbuild /t:restore Fint.Event.Model.sln'
        sh 'dotnet msbuild /t:build /p:Configuration=Release Fint.Event.Model.sln'
        sh 'dotnet msbuild /t:pack /p:Configuration=Release Fint.Event.Model.sln'
        sh 'dotnet test Fint.Event.Model.Tests'
        stash includes: "**/Release/*.nupkg", name: 'libs'
      }
    }
    stage('Deploy') {
      environment {
        NUGET_KEY = credentials('fint-nuget')
      }
      when {
        branch 'master'
      }
      steps {
        deleteDir()
        unstash 'libs'
        archiveArtifacts '**/*.nupkg'
        sh "dotnet nuget push Fint.Event.Model/bin/Release/Fint.Event.Model.*.nupkg -k ${NUGET_KEY} -s https://api.nuget.org/v3/index.json"
      }
    }
  }
}
