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
        sh 'dotnet msbuild Fint.Event.Model.sln'
        stash includes: "**/Release/*.nupkg", name: 'libs'
      }
    }
    stage('Deploy') {
      environment {
        BINTRAY = credentials('fint-bintray')
      }
      when {
        branch 'master'
      }
      steps {
        deleteDir()
        unstash 'libs'
        archiveArtifacts '**/*.nupkg'
      }
    }
  }
}