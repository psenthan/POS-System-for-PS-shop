USE [master]
GO

CREATE DATABASE [PSSupermarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PSSupermarket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PSSupermarket.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PSSupermarket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PSSupermarket_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PSSupermarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
