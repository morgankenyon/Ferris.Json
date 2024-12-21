## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.FerrisValueLoopMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+0C],0
       jle       near ptr M00_L02
M00_L00:
       mov       rcx,11483401E78
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+30]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC73D166D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+40],0
       jne       short M00_L03
       mov       rcx,11483401EC0
       mov       rcx,[rcx]
M00_L01:
       mov       rdx,rdi
       call      qword ptr [7FFC741C4330]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       mov       rcx,rax
       mov       ebp,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,6F547739
       mov       r9d,0EB78B9FC
       call      qword ptr [7FFC7420DE30]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,ebp
       mov       [rbx+8],eax
       inc       esi
       cmp       esi,[rbx+0C]
       jl        near ptr M00_L00
M00_L02:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       cmp       dword ptr [rsp+40],1
       je        short M00_L08
       mov       ebp,[rsp+40]
       test      ebp,ebp
       jl        near ptr M00_L10
       mov       r14,[rsp+30]
       test      r14,r14
       je        near ptr M00_L11
       cmp       [r14+8],ebp
       je        short M00_L06
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       rcx,[r15+10]
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       cmp       ebp,r8d
       jg        short M00_L07
       mov       r8d,ebp
M00_L04:
       mov       r8d,r8d
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       mov       [rsp+30],r15
M00_L06:
       mov       ecx,[rsp+40]
       mov       [rsp+44],ecx
       mov       rcx,[rsp+30]
       jmp       near ptr M00_L01
M00_L07:
       jmp       short M00_L04
M00_L08:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,rbp
       mov       r8,[rsp+38]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rbp
       jmp       near ptr M00_L01
M00_L09:
       call      qword ptr [7FFC73E75BD8]
       jmp       short M00_L05
M00_L10:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC73F5ED48]
       int       3
M00_L11:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+30],rax
       jmp       short M00_L06
; Total bytes of code 412
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rsi,rsi
       je        near ptr M01_L03
       test      bl,1
       je        short M01_L00
       mov       rdx,rsi
       mov       rcx,11483400590
       mov       rcx,[rcx]
       call      qword ptr [7FFC741C43C0]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rsi,rax
       mov       r13d,1
       mov       r12d,2
       jmp       short M01_L01
M01_L00:
       mov       r12d,1
M01_L01:
       cmp       byte ptr [rsp+0D8],0
       je        short M01_L04
       mov       ecx,[rsi+8]
       mov       eax,ecx
       cmp       word ptr [rsi+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rsi
       lea       r15d,[rcx-1]
       cmp       ecx,r15d
       jb        near ptr M01_L23
       test      r15d,r15d
       je        near ptr M01_L10
       cmp       ecx,r15d
       je        near ptr M01_L09
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,r15d
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFC73E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r15d,1
M01_L03:
       xor       r12d,r12d
M01_L04:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L11
       mov       rbp,rax
M01_L05:
       mov       [rsp+38],rsi
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L07
       mov       rax,[rsp+38]
M01_L06:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        near ptr M01_L12
       cmp       r12d,2
       je        near ptr M01_L14
       jmp       near ptr M01_L16
M01_L07:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
       jmp       short M01_L06
M01_L08:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFC73FB67F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L17
M01_L09:
       mov       rsi,r12
       jmp       near ptr M01_L02
M01_L10:
       mov       rsi,11480200008
       jmp       near ptr M01_L02
M01_L11:
       mov       rcx,rbp
       call      qword ptr [7FFC73D16658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L05
M01_L12:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC73FB5008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L13
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFC73FB67F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L13:
       mov       r12,rax
       jmp       short M01_L17
M01_L14:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC73FB5008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L15
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFC73FB67F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L15:
       jmp       short M01_L17
M01_L16:
       cmp       byte ptr [rbp+18],0
       je        near ptr M01_L08
       mov       r12,[rbp+8]
M01_L17:
       xor       ebx,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L20
M01_L18:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       je        short M01_L21
M01_L19:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L18
M01_L20:
       mov       rdx,[rsp+50]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rdi+10],eax
       mov       eax,[rsp+64]
       mov       [rdi+14],eax
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       test      r15d,r15d
       jne       short M01_L24
       test      r14,r14
       jne       short M01_L25
M01_L22:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFC73FB4F60]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M01_L19
M01_L23:
       mov       rcx,r12
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFC73DC7258]
       int       3
M01_L24:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFC73D16538]
       test      eax,eax
       je        near ptr M01_L19
       mov       r10,[rsp+40]
       test      r14,r14
       je        short M01_L22
M01_L25:
       mov       rcx,r10
       call      qword ptr [7FFC7406D0B8]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L19
       mov       r10,[rsp+40]
       jmp       short M01_L22
; Total bytes of code 836
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,258
       vzeroupper
       vmovaps   [rsp+240],xmm6
       vmovaps   [rsp+230],xmm7
       xor       eax,eax
       mov       [rsp+0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0D0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M02_L01:
       vmovdqa   xmmword ptr [rsp+rax+230],xmm4
       vmovdqa   xmmword ptr [rsp+rax+240],xmm4
       vmovdqa   xmmword ptr [rsp+rax+250],xmm4
       add       rax,30
       jne       short M02_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L141
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       xor       ebp,ebp
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L89
M02_L03:
       mov       ecx,ebp
       mov       r14,[rsi+rcx*8+10]
       mov       r15,[r14]
       mov       r13,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r15,r13
       jne       near ptr M02_L142
       mov       rcx,r14
       cmp       qword ptr [rcx+18],0
       je        short M02_L05
       mov       rcx,[r14+18]
M02_L04:
       test      rcx,rcx
       je        near ptr M02_L132
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFC73FA3208]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
       jmp       short M02_L06
M02_L05:
       xor       ecx,ecx
       jmp       short M02_L04
M02_L06:
       cmp       r15,r13
       jne       near ptr M02_L143
M02_L07:
       mov       rcx,r14
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
M02_L08:
       mov       rdx,[r14+38]
       mov       rax,[rdx+18]
M02_L09:
       mov       r10,rax
       mov       [rsp+0C0],r10
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r10],rdx
       jne       near ptr M02_L157
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+1B8]
       mov       rcx,r10
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC73D166D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+1C8],0
       jne       near ptr M02_L16
       mov       rcx,11483401EC0
       mov       rax,[rcx]
       jmp       near ptr M02_L14
M02_L10:
       mov       rcx,[r14+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+0A8],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+0A8]
       mov       [rsp+1F8],rdx
       mov       [rsp+200],rax
       lea       rdx,[rsp+1D8]
       mov       [rsp+20],rdx
       mov       edx,[r14+50]
       lea       rcx,[rsp+1F8]
       lea       r8,[rsp+1F0]
       lea       r9,[rsp+1E8]
       call      qword ptr [7FFC74015740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+1E0]
       mov       [rsp+1D0],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0B0],rax
       mov       r9,[r14+30]
       mov       rcx,rax
       mov       rdx,[rsp+1D0]
       mov       r8d,[rsp+1D8]
       call      qword ptr [7FFC73FB7AC8]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r14+38]
       mov       rdx,[rsp+0B0]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L11:
       mov       rdx,r10
       call      qword ptr [7FFC73E75BD8]
M02_L12:
       mov       rcx,[rsp+90]
       mov       [rsp+1B8],rcx
M02_L13:
       mov       ecx,[rsp+1C8]
       mov       [rsp+1CC],ecx
       mov       rax,[rsp+1B8]
M02_L14:
       mov       [rsp+0B8],rax
       test      r12,r12
       je        short M02_L15
       mov       rcx,11480200020
       mov       rax,[rsp+0C0]
       cmp       rax,rcx
       je        near ptr M02_L44
       mov       rcx,114802087C0
       cmp       rax,rcx
       je        near ptr M02_L44
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M02_L188
       jmp       near ptr M02_L20
M02_L15:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,11480208780
       mov       r8,11480208798
       call      qword ptr [7FFC73DC6B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M02_L72
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L16:
       cmp       dword ptr [rsp+1C8],1
       je        near ptr M02_L71
       mov       eax,[rsp+1C8]
       mov       [rsp+1B4],eax
       test      eax,eax
       jl        near ptr M02_L133
       mov       r8,[rsp+1B8]
       mov       [rsp+98],r8
       test      r8,r8
       je        near ptr M02_L156
       cmp       [r8+8],eax
       je        near ptr M02_L13
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+90],rax
       lea       rcx,[rax+10]
       mov       rdx,[rsp+98]
       lea       r10,[rdx+10]
       mov       edx,[rdx+8]
       mov       r9d,[rsp+1B4]
       cmp       r9d,edx
       jg        short M02_L19
       mov       edx,r9d
M02_L17:
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M02_L11
       mov       rdx,r10
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L12
M02_L18:
       inc       ebp
       cmp       [rsi+8],ebp
       jg        near ptr M02_L03
       jmp       near ptr M02_L89
M02_L19:
       jmp       short M02_L17
M02_L20:
       mov       rcx,rax
       call      qword ptr [7FFC73D17330]; System.RuntimeType.GetBaseType()
M02_L21:
       mov       rcx,114802021B8
       cmp       rax,rcx
       je        near ptr M02_L189
M02_L22:
       mov       rcx,11480208828
       mov       r8,[rsp+0C0]
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,11480208660
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,11480204FC0
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,11480208850
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,11480205F58
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,11480208878
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,114802088A0
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,114802088C8
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,114802088F0
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,11480205718
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,11480208918
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,11480208940
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,11480208968
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,11480204B88
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,11480208990
       cmp       r8,rcx
       jne       near ptr M02_L69
M02_L23:
       xor       ecx,ecx
       mov       [rsp+208],rcx
       mov       rcx,11483401E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC73F99EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+210],rax
       test      rax,rax
       je        near ptr M02_L191
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L24:
       mov       [rsp+220],rdx
       mov       [rsp+228],eax
       xor       ecx,ecx
       mov       [rsp+218],ecx
       mov       byte ptr [rsp+21C],0
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rax,[rsp+220]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+228]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L192
       mov       rcx,1148020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+218]
       inc       ecx
       mov       [rsp+218],ecx
M02_L25:
       cmp       r15,r13
       jne       near ptr M02_L194
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L62
M02_L26:
       cmp       byte ptr [rsp+21C],0
       jne       near ptr M02_L195
M02_L27:
       test      r15,r15
       je        near ptr M02_L195
       mov       r8d,[rsp+218]
       cmp       r8d,[rsp+228]
       ja        near ptr M02_L140
       mov       rcx,[rsp+220]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+228]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L195
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC73E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+218]
       add       edx,[r15+8]
       mov       [rsp+218],edx
M02_L28:
       mov       edx,[rsp+218]
       cmp       edx,[rsp+228]
       ja        near ptr M02_L140
       mov       rcx,[rsp+220]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+228]
       sub       eax,edx
       cmp       eax,2
       jb        near ptr M02_L196
       mov       rdx,11480208814
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       edx,[rsp+218]
       add       edx,2
       mov       [rsp+218],edx
M02_L29:
       mov       [rsp+148],r12
       cmp       byte ptr [rsp+21C],0
       jne       near ptr M02_L155
       mov       rdx,[rsp+148]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L92
       mov       rdx,[rsp+148]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L61
M02_L30:
       mov       rdx,[rsp+148]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73DC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       edx,[rsp+218]
       cmp       edx,[rsp+228]
       ja        near ptr M02_L140
       mov       rcx,[rsp+220]
       mov       r8d,edx
       lea       r14,[rcx+r8*2]
       mov       r12d,[rsp+228]
       sub       r12d,edx
       xor       r13d,r13d
       mov       rdx,offset MT_System.Single
       cmp       [rax],rdx
       jne       near ptr M02_L43
       add       rax,8
       mov       r15,[rsp+208]
       vmovss    xmm7,dword ptr [rax]
       test      r15,r15
       jne       near ptr M02_L40
       mov       r8,gs:[58]
       mov       rdx,[r8+40]
       cmp       dword ptr [rdx+190],2
       jl        near ptr M02_L144
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M02_L144
       mov       rax,[rdx]
       add       rax,10
M02_L31:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L32
       mov       rcx,11483400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L32
       mov       rcx,11483400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L145
M02_L32:
       cmp       byte ptr [rcx+61],0
       jne       near ptr M02_L146
M02_L33:
       mov       r8,[rcx+18]
       test      r8,r8
       je        near ptr M02_L146
M02_L34:
       vmovaps   xmm0,xmm7
       mov       [rsp+0D8],r13
       xor       edx,edx
       mov       [rsp+0E0],edx
       mov       [rsp+0C8],r14
       mov       [rsp+0D0],r12d
       lea       rdx,[rsp+138]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0D8]
       lea       r9,[rsp+0C8]
       call      qword ptr [7FFC741C7708]; System.Number.TryFormatSingle[[System.Char, System.Private.CoreLib]](Single, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo, System.Span`1<Char>, Int32 ByRef)
M02_L35:
       test      eax,eax
       je        near ptr M02_L197
       mov       r8d,[rsp+218]
       add       r8d,[rsp+138]
       mov       [rsp+218],r8d
M02_L36:
       xor       ecx,ecx
       mov       [rsp+140],rcx
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rax,[rsp+220]
       mov       [rsp+0D8],rax
       mov       [rsp+0E0],ecx
       lea       rcx,[rsp+0D8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       mov       r13,[rsp+210]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+208],ymm0
       vmovdqu   xmmword ptr [rsp+220],xmm0
       test      r13,r13
       je        near ptr M02_L39
       mov       rcx,11483401E70
       mov       r15,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFC73D05120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L148
M02_L37:
       xor       eax,eax
       mov       dword ptr [rsp+130],1
       cmp       [rcx+8],r12d
       jbe       short M02_L38
       mov       dword ptr [rsp+134],1
       mov       edx,10
       shlx      edx,edx,r12d
       cmp       [r13+8],edx
       jne       near ptr M02_L137
       cmp       r12d,[rcx+8]
       jae       near ptr M02_L199
       mov       edx,r12d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+48],r10
       mov       r9,[r10]
       mov       [rsp+40],r9
       mov       rcx,r10
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+48]
       mov       [rdx+8],ecx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+134]
       jne       near ptr M02_L149
M02_L38:
       mov       rcx,114834005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L114
M02_L39:
       mov       rdx,r14
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short M02_L42
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L199
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L40:
       mov       rdx,r15
       mov       rcx,offset MT_System.Globalization.CultureInfo
       call      qword ptr [7FFC73DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L94
       cmp       byte ptr [rax+61],0
       jne       near ptr M02_L94
       mov       r8,[rax+18]
       test      r8,r8
       je        near ptr M02_L55
M02_L41:
       jmp       near ptr M02_L34
M02_L42:
       mov       rcx,rdi
       call      qword ptr [7FFC73E7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L43:
       mov       rcx,rax
       mov       [rsp+0C8],r14
       mov       [rsp+0D0],r12d
       mov       [rsp+0D8],r13
       xor       edx,edx
       mov       [rsp+0E0],edx
       mov       rdx,[rsp+208]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0C8]
       lea       r9,[rsp+0D8]
       lea       r8,[rsp+138]
       mov       r11,7FFC73C805D0
       call      qword ptr [r11]
       jmp       near ptr M02_L35
M02_L44:
       xor       ecx,ecx
       mov       [rsp+208],rcx
       mov       rcx,11483401E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC73F99EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+210],rax
       test      rax,rax
       je        near ptr M02_L158
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L45:
       mov       [rsp+220],rdx
       mov       [rsp+228],eax
       xor       ecx,ecx
       mov       [rsp+218],ecx
       mov       byte ptr [rsp+21C],0
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rax,[rsp+220]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+228]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L159
       mov       rcx,1148020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+218]
       inc       ecx
       mov       [rsp+218],ecx
M02_L46:
       cmp       r15,r13
       jne       near ptr M02_L161
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L53
M02_L47:
       cmp       byte ptr [rsp+21C],0
       jne       near ptr M02_L162
M02_L48:
       test      r15,r15
       je        near ptr M02_L162
       mov       r8d,[rsp+218]
       cmp       r8d,[rsp+228]
       ja        near ptr M02_L140
       mov       rcx,[rsp+220]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+228]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L162
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC73E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+218]
       add       edx,[r15+8]
       mov       [rsp+218],edx
M02_L49:
       mov       edx,[rsp+218]
       cmp       edx,[rsp+228]
       ja        near ptr M02_L140
       mov       rcx,[rsp+220]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+228]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L163
       mov       rdx,114802087F4
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rsp+218]
       add       edx,3
       mov       [rsp+218],edx
M02_L50:
       mov       [rsp+198],r12
       cmp       byte ptr [rsp+21C],0
       jne       near ptr M02_L151
       mov       rdx,[rsp+198]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L84
       mov       rdx,[rsp+198]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73DC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L52
M02_L51:
       mov       rdx,[rsp+198]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73DC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       edx,[rsp+218]
       cmp       edx,[rsp+228]
       ja        near ptr M02_L140
       mov       r8,[rsp+220]
       mov       r9d,edx
       lea       r15,[r8+r9*2]
       mov       r14d,[rsp+228]
       sub       r14d,edx
       xor       r12d,r12d
       mov       rdx,offset MT_System.Single
       cmp       [rax],rdx
       jne       near ptr M02_L66
       add       rax,8
       mov       rcx,[rsp+208]
       vmovss    xmm6,dword ptr [rax]
       test      rcx,rcx
       je        near ptr M02_L79
       jmp       near ptr M02_L78
M02_L52:
       mov       rdx,[rsp+198]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73DC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+208]
       mov       r11,7FFC73C805B8
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L87
M02_L53:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L160
       mov       rcx,r15
       call      qword ptr [7FFC73E75050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L54:
       mov       [rsp+1A0],r15
       mov       [rsp+1A8],eax
       lea       rcx,[rsp+1A0]
       call      qword ptr [7FFC73FB6B98]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L47
M02_L55:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r8,rax
       jmp       near ptr M02_L41
M02_L56:
       xor       ecx,ecx
       mov       [rsp+190],rcx
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rax,[rsp+220]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+228]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L170
       mov       rcx,1148020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+218]
       inc       ecx
       mov       [rsp+218],ecx
M02_L57:
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rax,[rsp+220]
       mov       [rsp+0D8],rax
       mov       [rsp+0E0],ecx
       lea       rcx,[rsp+0D8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r14,[rsp+210]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+208],ymm0
       vmovdqu   xmmword ptr [rsp+220],xmm0
       test      r14,r14
       je        near ptr M02_L60
       mov       rcx,11483401E70
       mov       r12,[rcx]
       mov       ecx,[r14+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFC73D05120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L152
M02_L58:
       xor       eax,eax
       mov       dword ptr [rsp+180],1
       cmp       [rcx+8],r13d
       jbe       short M02_L59
       mov       dword ptr [rsp+184],1
       mov       edx,10
       shlx      edx,edx,r13d
       cmp       [r14+8],edx
       jne       near ptr M02_L135
       mov       edx,r13d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+78],r10
       mov       r9,[r10]
       mov       [rsp+70],r9
       mov       rcx,r10
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+78]
       mov       [rdx+8],ecx
       mov       rax,[rsp+70]
       test      rax,rax
       mov       [rsp+70],rax
       mov       eax,[rsp+184]
       jne       near ptr M02_L153
M02_L59:
       mov       rcx,114834005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L183
M02_L60:
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L65
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L61:
       mov       rdx,[rsp+148]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73DC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+208]
       mov       r11,7FFC73C805C8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L91
M02_L62:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L193
       mov       rcx,r15
       call      qword ptr [7FFC73E75050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L63:
       mov       rcx,114834009F0
       mov       r8,[rcx]
       mov       edx,eax
       test      edx,edx
       jl        near ptr M02_L140
       test      edx,edx
       je        near ptr M02_L70
       mov       rcx,r15
M02_L64:
       mov       [rsp+150],rcx
       call      qword ptr [7FFC73DC66E8]; System.String.CreateStringFromEncoding(Byte*, Int32, System.Text.Encoding)
       mov       r15,rax
       xor       ecx,ecx
       mov       [rsp+150],rcx
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L26
M02_L65:
       mov       rcx,rdi
       call      qword ptr [7FFC73E7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L66:
       mov       rcx,rax
       mov       [rsp+0C8],r15
       mov       [rsp+0D0],r14d
       mov       [rsp+0D8],r12
       xor       edx,edx
       mov       [rsp+0E0],edx
       mov       rdx,[rsp+208]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0C8]
       lea       r9,[rsp+0D8]
       lea       r8,[rsp+188]
       mov       r11,7FFC73C805C0
       call      qword ptr [r11]
M02_L67:
       test      eax,eax
       je        near ptr M02_L164
       mov       r8d,[rsp+218]
       add       r8d,[rsp+188]
       mov       [rsp+218],r8d
       jmp       near ptr M02_L56
M02_L68:
       vmovaps   xmm0,xmm6
       mov       [rsp+0D8],r12
       xor       edx,edx
       mov       [rsp+0E0],edx
       mov       [rsp+0C8],r15
       mov       [rsp+0D0],r14d
       lea       rdx,[rsp+188]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0D8]
       lea       r9,[rsp+0C8]
       call      qword ptr [7FFC741C7708]; System.Number.TryFormatSingle[[System.Char, System.Private.CoreLib]](Single, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L67
M02_L69:
       mov       rax,11480203C30
       cmp       r8,rax
       jne       near ptr M02_L124
       cmp       r15,r13
       jne       near ptr M02_L119
       mov       r13,[r14+8]
       test      r13,r13
       jne       near ptr M02_L74
       jmp       short M02_L73
M02_L70:
       mov       ecx,1
       jmp       near ptr M02_L64
M02_L71:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0A0],rax
       mov       rcx,rax
       mov       r8,[rsp+1C0]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rsp+0A0]
       jmp       near ptr M02_L14
M02_L72:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC73E7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L73:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0F8],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rsp+0F8]
       call      qword ptr [7FFC73FB6B20]
       vmovups   xmm0,[rsp+0F8]
       vmovups   [rsp+0E8],xmm0
       lea       rcx,[rsp+0E8]
       call      qword ptr [7FFC73FB6B98]; System.MdUtf8String.ToString()
       mov       r13,rax
       lea       rcx,[r14+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L74:
       mov       rax,offset MT_System.Boolean
       cmp       [r12],rax
       jne       near ptr M02_L121
       add       r12,8
       cmp       byte ptr [r12],0
       je        near ptr M02_L120
       mov       r12,11480208A08
M02_L75:
       cmp       [r12],r12b
       call      qword ptr [7FFC73F04180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       near ptr M02_L97
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC73EDCFF8]; System.Globalization.CultureInfo.get_TextInfo()
M02_L76:
       cmp       [rax],al
       test      r12,r12
       je        near ptr M02_L138
       mov       rcx,rax
       mov       rdx,r12
       call      qword ptr [7FFC741C43C0]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       r12,rax
       test      r13,r13
       je        near ptr M02_L122
       cmp       dword ptr [r13+8],0
       je        near ptr M02_L122
       test      r12,r12
       je        near ptr M02_L123
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L123
       mov       ecx,[r13+8]
       mov       eax,[r12+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L139
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r8,[r15+0C]
       mov       rcx,1148020878C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r15+0E]
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFC73E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r13+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r15+r8*2+0C]
       mov       rcx,11480208814
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r13+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFC73E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r15
M02_L77:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L88
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L199
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L78:
       call      qword ptr [7FFC73EEF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       jmp       near ptr M02_L68
M02_L79:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+40]
       cmp       dword ptr [rdx+190],2
       jl        near ptr M02_L165
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M02_L165
       mov       rax,[rdx]
       add       rax,10
M02_L80:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L81
       mov       rcx,11483400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L81
       mov       rcx,11483400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L166
M02_L81:
       cmp       byte ptr [rcx+61],0
       jne       short M02_L82
       mov       r8,[rcx+18]
       test      r8,r8
       je        short M02_L82
       jmp       near ptr M02_L68
M02_L82:
       mov       rdx,114802019C8
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       r8,rax
       test      r8,r8
       je        short M02_L83
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       cmp       [r8],rcx
       jne       near ptr M02_L134
M02_L83:
       jmp       near ptr M02_L68
M02_L84:
       xor       r8d,r8d
       mov       [rsp+190],r8
       lea       r8,[rsp+198]
       cmp       qword ptr [rsp+190],0
       jne       short M02_L85
       mov       r8,[r8]
       mov       [rsp+190],r8
       lea       r8,[rsp+190]
       cmp       qword ptr [rsp+190],0
       je        near ptr M02_L167
M02_L85:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L168
M02_L86:
       mov       rdx,rcx
M02_L87:
       test      rdx,rdx
       je        near ptr M02_L56
       mov       r8d,[rsp+218]
       cmp       r8d,[rsp+228]
       ja        near ptr M02_L140
       mov       rcx,[rsp+220]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+228]
       sub       eax,r8d
       mov       r14d,[rdx+8]
       cmp       r14d,eax
       ja        near ptr M02_L169
       add       rdx,0C
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFC73E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+218]
       mov       [rsp+218],r14d
       jmp       near ptr M02_L56
M02_L88:
       mov       rcx,rdi
       call      qword ptr [7FFC73E7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L89:
       mov       rdx,rdi
       mov       rcx,11480200C60
       call      qword ptr [7FFC73DC6DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rdx,rax
       mov       rcx,114802089B8
       mov       r8,114802089D0
       call      qword ptr [7FFC73DC6B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       vmovaps   xmm6,[rsp+240]
       vmovaps   xmm7,[rsp+230]
       add       rsp,258
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L90:
       mov       r15,rcx
M02_L91:
       test      r15,r15
       je        near ptr M02_L36
       mov       r8d,[rsp+218]
       cmp       r8d,[rsp+228]
       ja        near ptr M02_L140
       mov       rcx,[rsp+220]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+228]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L101
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC73E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+218]
       add       ecx,[r15+8]
       mov       [rsp+218],ecx
       jmp       near ptr M02_L36
M02_L92:
       xor       r8d,r8d
       mov       [rsp+140],r8
       lea       r8,[rsp+148]
       cmp       qword ptr [rsp+140],0
       jne       short M02_L93
       mov       r8,[r8]
       mov       [rsp+140],r8
       lea       r8,[rsp+140]
       cmp       qword ptr [rsp+140],0
       je        short M02_L99
M02_L93:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       short M02_L100
       cmp       [rcx],cl
       jmp       near ptr M02_L90
M02_L94:
       mov       r8,r15
       mov       rdx,offset MT_System.Globalization.NumberFormatInfo
       cmp       [r8],rdx
       jne       short M02_L98
M02_L95:
       test      r8,r8
       je        near ptr M02_L198
M02_L96:
       jmp       near ptr M02_L41
M02_L97:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       jmp       near ptr M02_L76
M02_L98:
       xor       r8d,r8d
       jmp       short M02_L95
M02_L99:
       xor       r15d,r15d
       jmp       near ptr M02_L91
M02_L100:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L90
M02_L101:
       lea       rcx,[rsp+208]
       mov       rdx,r15
       call      qword ptr [7FFC73EE58F0]
       jmp       near ptr M02_L36
M02_L102:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+114],eax
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+114]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L103
       call      qword ptr [7FFC7438CC90]
       mov       edx,eax
       jmp       short M02_L104
M02_L103:
       mov       edx,ecx
       sar       edx,10
M02_L104:
       mov       [rsp+118],edx
M02_L105:
       mov       rcx,7FFC73D05120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+118]
       xor       edx,edx
       div       dword ptr [7FFC73D05C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L112
M02_L106:
       cmp       eax,[r8+8]
       jae       near ptr M02_L199
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+110],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+10C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L108
       test      r10d,r10d
       jne       short M02_L109
       xor       edx,edx
       mov       [rax+14],edx
M02_L107:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M02_L108:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+110]
       test      ecx,ecx
       je        short M02_L110
       mov       r8d,1
       jmp       short M02_L113
M02_L109:
       jmp       short M02_L107
M02_L110:
       mov       eax,[rsp+120]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M02_L111
       xor       r8d,r8d
M02_L111:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,r8d
M02_L112:
       mov       r8,[rsp+38]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L106
       xor       r8d,r8d
M02_L113:
       mov       eax,r8d
       mov       [rsp+130],eax
       mov       eax,[rsp+134]
       jmp       near ptr M02_L38
M02_L114:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+130]
       cmp       dword ptr [r13+8],0
       mov       [rsp+134],edx
       mov       [rsp+58],r8
       mov       [rsp+130],eax
       je        near ptr M02_L39
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+12C],eax
       mov       edx,[r13+8]
       mov       [rsp+128],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+12C]
       mov       r9d,[rsp+128]
       mov       edx,3
       call      qword ptr [7FFC73E77678]
       mov       eax,[rsp+134]
       test      [rsp+130],eax
       mov       [rsp+134],eax
       jne       near ptr M02_L39
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+124],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rsp+134]
       test      r15d,r15d
       jne       short M02_L115
       mov       r12,[rsp+50]
       mov       edx,[rsp+124]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L116
M02_L115:
       mov       rdx,[rsp+50]
       mov       ecx,[rsp+124]
       mov       r8d,ecx
       mov       ecx,r12d
       mov       r12,rdx
       mov       edx,r8d
M02_L116:
       mov       r8d,r13d
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L117
       mov       eax,1
       jmp       short M02_L118
M02_L117:
       xor       eax,eax
M02_L118:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r12
       call      qword ptr [7FFC73F8E2B0]
       jmp       near ptr M02_L39
M02_L119:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       short M02_L121
M02_L120:
       mov       r12,114802089E8
       jmp       near ptr M02_L75
M02_L121:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M02_L75
M02_L122:
       mov       r8,r12
       mov       rcx,11480208780
       mov       rdx,11480208808
       call      qword ptr [7FFC73DC6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L77
M02_L123:
       mov       rdx,r13
       mov       rcx,11480208780
       mov       r8,11480208808
       call      qword ptr [7FFC73DC6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L77
M02_L124:
       lea       rcx,[rsp+208]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFC73EE56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rdx,[rsp+220]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+228]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L125
       mov       rcx,1148020878C
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+218]
       inc       ecx
       mov       [rsp+218],ecx
       jmp       short M02_L126
M02_L125:
       lea       rcx,[rsp+208]
       mov       rdx,11480208780
       call      qword ptr [7FFC73EE58F0]
M02_L126:
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rsp+208]
       call      qword ptr [7FFC73EE5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rdx,[rsp+220]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+228]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L127
       mov       rcx,114802087F4
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rsp+218]
       add       ecx,3
       mov       [rsp+218],ecx
       jmp       short M02_L128
M02_L127:
       lea       rcx,[rsp+208]
       mov       rdx,114802087E8
       call      qword ptr [7FFC73EE58F0]
M02_L128:
       lea       rcx,[rsp+208]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFC74046EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+218]
       cmp       ecx,[rsp+228]
       ja        near ptr M02_L140
       mov       rdx,[rsp+220]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+228]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L129
       mov       rcx,1148020878C
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+218]
       inc       ecx
       mov       [rsp+218],ecx
       jmp       short M02_L130
M02_L129:
       lea       rcx,[rsp+208]
       mov       rdx,11480208780
       call      qword ptr [7FFC73EE58F0]
M02_L130:
       lea       rcx,[rsp+208]
       call      qword ptr [7FFC73EE5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L131
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M02_L199
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L131:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC73E7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L132:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC74374840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC73DCF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L133:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC73F5ED48]
       int       3
M02_L134:
       mov       rdx,rax
       call      qword ptr [7FFC73DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L135:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC74376AC0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC73C74000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC73DCF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L136:
       mov       rdx,rax
       call      qword ptr [7FFC73DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC74376AC0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC73C74000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC73DCF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L138:
       mov       ecx,16EB
       mov       rdx,7FFC73C74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC73F866E8]
       int       3
M02_L139:
       call      qword ptr [7FFC73F5EF40]
       int       3
M02_L140:
       call      qword ptr [7FFC73F5E9D0]
       int       3
M02_L141:
       mov       rcx,11483401E90
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L142:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r15+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       cmp       r15,r13
       je        near ptr M02_L07
M02_L143:
       mov       rcx,r14
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M02_L09
M02_L144:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L31
M02_L145:
       call      qword ptr [7FFC73F04030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       cmp       byte ptr [rcx+61],0
       je        near ptr M02_L33
M02_L146:
       mov       rdx,114802019C8
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       r8,rax
       test      r8,r8
       je        short M02_L147
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       cmp       [r8],rcx
       jne       near ptr M02_L136
M02_L147:
       jmp       near ptr M02_L34
M02_L148:
       mov       rcx,r15
       call      qword ptr [7FFC73F8D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L37
M02_L149:
       mov       rcx,[r15+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M02_L199
       mov       edx,r12d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+134],eax
       jne       short M02_L150
       mov       rcx,r15
       mov       edx,r12d
       call      qword ptr [7FFC73F8D7E8]
       mov       r10,rax
M02_L150:
       mov       r10,[r10+8]
       mov       [rsp+38],r10
       mov       rcx,7FFC73D05120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC73D05C38],0
       je        near ptr M02_L102
       call      qword ptr [7FFC73DCDC98]
       mov       edx,eax
       mov       [rsp+118],edx
       jmp       near ptr M02_L105
M02_L151:
       lea       rcx,[rsp+208]
       mov       r8,[rsp+198]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC7438CE28]
       jmp       near ptr M02_L56
M02_L152:
       mov       rcx,r12
       call      qword ptr [7FFC73F8D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L58
M02_L153:
       mov       rcx,[r12+10]
       cmp       r13d,[rcx+8]
       jae       near ptr M02_L199
       mov       edx,r13d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+184],eax
       jne       short M02_L154
       mov       rcx,r12
       mov       edx,r13d
       call      qword ptr [7FFC73F8D7E8]
       mov       r10,rax
M02_L154:
       mov       r10,[r10+8]
       mov       [rsp+68],r10
       mov       rcx,7FFC73D05120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC73D05C38],0
       je        near ptr M02_L171
       call      qword ptr [7FFC73DCDC98]
       mov       edx,eax
       mov       [rsp+168],edx
       jmp       near ptr M02_L174
M02_L155:
       lea       rcx,[rsp+208]
       mov       r8,[rsp+148]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC7438CE28]
       jmp       near ptr M02_L36
M02_L156:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+1B8],rax
       jmp       near ptr M02_L13
M02_L157:
       mov       rcx,r10
       mov       edx,1C
       mov       rax,[r10]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M02_L14
M02_L158:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L45
M02_L159:
       lea       rcx,[rsp+208]
       mov       rdx,11480208780
       call      qword ptr [7FFC73EE58F0]
       jmp       near ptr M02_L46
M02_L160:
       xor       eax,eax
       jmp       near ptr M02_L54
M02_L161:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+21C],0
       je        near ptr M02_L48
M02_L162:
       lea       rcx,[rsp+208]
       mov       rdx,r15
       call      qword ptr [7FFC73EE5848]
       jmp       near ptr M02_L49
M02_L163:
       lea       rcx,[rsp+208]
       mov       rdx,114802087E8
       call      qword ptr [7FFC73EE58F0]
       jmp       near ptr M02_L50
M02_L164:
       lea       rcx,[rsp+208]
       call      qword ptr [7FFC73EE5938]
       jmp       near ptr M02_L51
M02_L165:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L80
M02_L166:
       call      qword ptr [7FFC73F04030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L81
M02_L167:
       xor       edx,edx
       jmp       near ptr M02_L87
M02_L168:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L86
M02_L169:
       lea       rcx,[rsp+208]
       call      qword ptr [7FFC73EE58F0]
       jmp       near ptr M02_L56
M02_L170:
       lea       rcx,[rsp+208]
       mov       rdx,11480208780
       call      qword ptr [7FFC73EE58F0]
       jmp       near ptr M02_L57
M02_L171:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+164],eax
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+164]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L172
       call      qword ptr [7FFC7438CC90]
       mov       edx,eax
       jmp       short M02_L173
M02_L172:
       mov       edx,ecx
       sar       edx,10
M02_L173:
       mov       [rsp+168],edx
M02_L174:
       mov       rcx,7FFC73D05120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+168]
       xor       edx,edx
       div       dword ptr [7FFC73D05C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L181
M02_L175:
       cmp       eax,[r8+8]
       jae       near ptr M02_L199
       mov       [rsp+170],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+60],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+160],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+15C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L177
       test      r10d,r10d
       jne       short M02_L178
       xor       edx,edx
       mov       [rax+14],edx
M02_L176:
       movsxd    rdx,r10d
       mov       r8,[rsp+70]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+15C]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+160],1
M02_L177:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+160]
       test      ecx,ecx
       je        short M02_L179
       mov       r8d,1
       jmp       short M02_L182
M02_L178:
       jmp       short M02_L176
M02_L179:
       mov       eax,[rsp+170]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+68]
       cmp       [rcx+8],r8d
       jne       short M02_L180
       xor       r8d,r8d
M02_L180:
       mov       edx,[rsp+16C]
       inc       edx
       mov       eax,r8d
M02_L181:
       mov       r8,[rsp+68]
       mov       [rsp+16C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L175
       xor       r8d,r8d
M02_L182:
       mov       eax,r8d
       mov       [rsp+180],eax
       mov       eax,[rsp+184]
       jmp       near ptr M02_L59
M02_L183:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+180]
       cmp       dword ptr [r14+8],0
       mov       [rsp+184],edx
       mov       [rsp+88],r8
       mov       [rsp+180],eax
       je        near ptr M02_L60
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+17C],eax
       mov       edx,[r14+8]
       mov       [rsp+178],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+17C]
       mov       r9d,[rsp+178]
       mov       edx,3
       call      qword ptr [7FFC73E77678]
       mov       eax,[rsp+184]
       test      [rsp+180],eax
       mov       [rsp+184],eax
       jne       near ptr M02_L60
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,[r14+8]
       mov       rdx,[rsp+88]
       mov       [rsp+80],rdx
       mov       [rsp+174],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rsp+184]
       test      r12d,r12d
       jne       short M02_L184
       mov       r13,[rsp+80]
       mov       edx,[rsp+174]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L185
M02_L184:
       mov       rdx,[rsp+80]
       mov       ecx,[rsp+174]
       mov       r8d,ecx
       mov       ecx,r13d
       mov       r13,rdx
       mov       edx,r8d
M02_L185:
       mov       r8d,r14d
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L186
       mov       eax,1
       jmp       short M02_L187
M02_L186:
       xor       eax,eax
M02_L187:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r13
       call      qword ptr [7FFC73F8E2B0]
       jmp       near ptr M02_L60
M02_L188:
       mov       rcx,rax
       mov       r8,[rax]
       mov       r8,[r8+98]
       call      qword ptr [r8+20]
       jmp       near ptr M02_L21
M02_L189:
       mov       rcx,[rsp+0B8]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L22
       mov       rcx,[rsp+0B8]
       mov       rdx,r12
       call      qword ptr [7FFC741C4330]
       mov       r13,rax
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r13
       mov       rcx,11480208780
       mov       r8,11480208808
       call      qword ptr [7FFC73DC6B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L190
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L190:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC73E7E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L191:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L24
M02_L192:
       lea       rcx,[rsp+208]
       mov       rdx,11480208780
       call      qword ptr [7FFC73EE58F0]
       jmp       near ptr M02_L25
M02_L193:
       xor       eax,eax
       jmp       near ptr M02_L63
M02_L194:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+21C],0
       je        near ptr M02_L27
M02_L195:
       lea       rcx,[rsp+208]
       mov       rdx,r15
       call      qword ptr [7FFC73EE5848]
       jmp       near ptr M02_L28
M02_L196:
       lea       rcx,[rsp+208]
       mov       rdx,11480208808
       call      qword ptr [7FFC73EE58F0]
       jmp       near ptr M02_L29
M02_L197:
       lea       rcx,[rsp+208]
       call      qword ptr [7FFC73EE5938]
       jmp       near ptr M02_L30
M02_L198:
       mov       rcx,r15
       mov       r11,7FFC73C805D8
       mov       rdx,114802019C8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC73DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r8,rax
       test      r8,r8
       jne       near ptr M02_L96
       call      qword ptr [7FFC73EEF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,rax
       jmp       near ptr M02_L96
M02_L199:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 8948
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.NewtonsoftValueLoopMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+0C],0
       jle       near ptr M00_L03
       mov       rdi,1895E401E78
M00_L00:
       mov       rbp,[rdi]
       mov       rcx,1895E404E38
       mov       rax,[rcx]
       test      rax,rax
       jne       short M00_L04
       xor       r14d,r14d
M00_L01:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFC741B69B8]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       short M00_L05
M00_L02:
       mov       rcx,rbp
       mov       r8,r15
       xor       edx,edx
       call      qword ptr [7FFC741B4420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       r14d,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0C9A74271
       mov       r9d,0B05B439A
       call      qword ptr [7FFC74315F68]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,r14d
       mov       [rbx+8],eax
       inc       esi
       cmp       esi,[rbx+0C]
       jl        short M00_L00
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       short M00_L01
M00_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC741B6A30]
       jmp       short M00_L02
; Total bytes of code 193
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,1895E404E80
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,1895E405078
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1895E404E88
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1895E405060
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1895E400428
       mov       r13,[rcx]
       mov       rcx,1895E4014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18900201C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,1895E405028
       mov       rax,1895E405030
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFC7418A878
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC73E4D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFC73FD9968]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFC741BEB50]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFC73C50CE8
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.TextJsonValueLoopMapping()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+0C],0
       jle       near ptr M00_L04
M00_L00:
       mov       rdx,1A0DEC01E78
       mov       rdx,[rdx]
       mov       [rsp+40],rdx
       mov       rdx,1A0DEC04EF8
       mov       rdi,[rdx]
       test      rdi,rdi
       je        near ptr M00_L06
       cmp       byte ptr [rdi+9E],0
       je        near ptr M00_L07
M00_L01:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L08
       mov       rdx,[rbp+0B8]
       mov       r8,1A080208758
       cmp       rdx,r8
       jne       near ptr M00_L08
M00_L02:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       je        short M00_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       short M00_L05
M00_L03:
       lea       rdx,[rsp+40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.ValueTestObject ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFC741A6FD0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rcx,rax
       mov       edi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,7008E94F
       mov       r9d,97AA4735
       call      qword ptr [7FFC74265140]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,edi
       mov       [rbx+8],eax
       inc       esi
       cmp       esi,[rbx+0C]
       jl        near ptr M00_L00
M00_L04:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFC73DA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L06:
       mov       rcx,1A0DEC04EF8
       xor       edx,edx
       call      qword ptr [7FFC741A5AB8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rdi,rax
       cmp       byte ptr [rdi+9E],0
       jne       near ptr M00_L01
M00_L07:
       mov       rcx,rdi
       call      qword ptr [7FFC741A5A10]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L08:
       mov       byte ptr [rsp+38],1
       mov       byte ptr [rsp+39],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       movzx     r9d,word ptr [rsp+38]
       mov       rdx,1A080208758
       mov       r8d,1
       call      qword ptr [7FFC741A52C0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
; Total bytes of code 353
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC741A5A88]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L12
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,1A0DEC01F88
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFC74388018]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M01_L02
M01_L01:
       mov       edx,2
M01_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L13
       mov       rdi,1A080201C08
M01_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC741A6D90]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L08
       cmp       [rcx+8],r15d
       jb        short M01_L07
M01_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L06:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M01_L07
       mov       r12d,r15d
       jmp       short M01_L10
M01_L07:
       call      qword ptr [7FFC73F3E9D0]
       int       3
M01_L08:
       test      r15d,r15d
       jne       short M01_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L06
M01_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFC741AD908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFC7437D1E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,7FFC7419C7C0
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A0DEC04F38
       mov       rdi,[rcx]
       jmp       near ptr M01_L03
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFC74376748]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFC7437CCF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFC743768C8]
       mov       r14,r13
       jmp       near ptr M01_L04
M01_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L18
M01_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L19
M01_L18:
       mov       rax,[rcx]
       add       rax,10
M01_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L20
       test      r10d,r10d
       jne       short M01_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L23
M01_L20:
       cmp       [rcx+8],r10d
       jae       short M01_L22
M01_L21:
       call      qword ptr [7FFC73F3E9D0]
       int       3
M01_L22:
       add       rcx,10
M01_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L25
       cmp       rdx,300
       ja        short M01_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFC73E55BA8]
M01_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1A0DEC01F88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC74388020]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1184
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M02_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M02_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M02_L00
       test      dl,4
       jne       short M02_L03
M02_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M02_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M02_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M02_L01
M02_L04:
       cmp       edx,4
       jae       short M02_L03
       mov       eax,80
       test      dl,1
       je        short M02_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M02_L05:
       test      dl,2
       mov       edx,eax
       je        short M02_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M02_L02
; Total bytes of code 266
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M03_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M03_L02
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       jne       short M03_L00
M03_L03:
       lea       rax,[7FFCD375B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFC741A5440]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFC741A4828]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFC741A76F0]
       mov       [rbp-40],rax
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFC741A75E8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M04_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFC741A54A0]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFC741A7678]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M04_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M04_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M05_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFC741A4828]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M05_L05
       call      qword ptr [7FFC741A75E8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFC73DA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M05_L03
       jmp       near ptr M05_L09
M05_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L03:
       call      qword ptr [7FFC741A77F8]
       test      eax,eax
       je        near ptr M05_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFC74264450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFC74264450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFC74264480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC741A76C0]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M05_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74264318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74264318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74264318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC741A5A10]
       jmp       short M05_L09
M05_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74264390]
       jmp       short M05_L09
M05_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFC73DA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L07
M05_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M05_L08
M05_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M05_L08:
       cmp       dword ptr [rbp-34],0
       je        short M05_L09
       call      qword ptr [7FFC741AC978]
M05_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC741A59C8]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M06_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC741A5278]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74264360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       cmp       qword ptr [rbp-8],0
       je        short M06_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC741A66A0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M06_L01
M06_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC741A5A28]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M06_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M06_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC74064720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M06_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC741A5488]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC741ACF60]
M06_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.FerrisValueMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,1E5F0C01E78
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+30]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC73CE66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+40],0
       je        near ptr M00_L04
       cmp       dword ptr [rsp+40],1
       je        near ptr M00_L05
       mov       edi,[rsp+40]
       test      edi,edi
       jl        near ptr M00_L06
       mov       rbp,[rsp+30]
       test      rbp,rbp
       je        near ptr M00_L07
       mov       r14d,[rbp+8]
       cmp       r14d,edi
       je        short M00_L01
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       rcx,[r15+10]
       lea       rdx,[rbp+10]
       cmp       edi,r14d
       cmovg     edi,r14d
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L03
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       [rsp+30],r15
M00_L01:
       mov       ecx,[rsp+40]
       mov       [rsp+44],ecx
       mov       rcx,[rsp+30]
M00_L02:
       mov       rdx,rsi
       call      qword ptr [7FFC74194330]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,4620C144
       mov       r9d,60780C46
       call      qword ptr [7FFC741DDE30]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       call      qword ptr [7FFC73E45BD8]
       jmp       short M00_L00
M00_L04:
       mov       rdx,1E5F0C01EC0
       mov       rcx,[rdx]
       jmp       short M00_L02
M00_L05:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+38]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rdi
       jmp       short M00_L02
M00_L06:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC73F2ED48]
       int       3
M00_L07:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+30],rax
       jmp       near ptr M00_L01
; Total bytes of code 390
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rsi,rsi
       je        near ptr M01_L03
       test      bl,1
       je        short M01_L00
       mov       rdx,rsi
       mov       rcx,1E5F0C00590
       mov       rcx,[rcx]
       call      qword ptr [7FFC741943C0]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rsi,rax
       mov       r13d,1
       mov       r12d,2
       jmp       short M01_L01
M01_L00:
       mov       r12d,1
M01_L01:
       cmp       byte ptr [rsp+0D8],0
       je        short M01_L04
       mov       ecx,[rsi+8]
       mov       eax,ecx
       cmp       word ptr [rsi+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rsi
       lea       r15d,[rcx-1]
       cmp       ecx,r15d
       jb        near ptr M01_L23
       test      r15d,r15d
       je        near ptr M01_L10
       cmp       ecx,r15d
       je        near ptr M01_L09
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,r15d
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFC73E45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r15d,1
M01_L03:
       xor       r12d,r12d
M01_L04:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L11
       mov       rbp,rax
M01_L05:
       mov       [rsp+38],rsi
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L07
       mov       rax,[rsp+38]
M01_L06:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        near ptr M01_L12
       cmp       r12d,2
       je        near ptr M01_L14
       jmp       near ptr M01_L16
M01_L07:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
       jmp       short M01_L06
M01_L08:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFC73F867F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L17
M01_L09:
       mov       rsi,r12
       jmp       near ptr M01_L02
M01_L10:
       mov       rsi,1E580200008
       jmp       near ptr M01_L02
M01_L11:
       mov       rcx,rbp
       call      qword ptr [7FFC73CE6658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L05
M01_L12:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC73F85008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L13
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFC73F867F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L13:
       mov       r12,rax
       jmp       short M01_L17
M01_L14:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC73F85008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L15
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFC73F867F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L15:
       jmp       short M01_L17
M01_L16:
       cmp       byte ptr [rbp+18],0
       je        near ptr M01_L08
       mov       r12,[rbp+8]
M01_L17:
       xor       ebx,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L20
M01_L18:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       je        short M01_L21
M01_L19:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L18
M01_L20:
       mov       rdx,[rsp+50]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rdi+10],eax
       mov       eax,[rsp+64]
       mov       [rdi+14],eax
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       test      r15d,r15d
       jne       short M01_L24
       test      r14,r14
       jne       short M01_L25
M01_L22:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFC73F84F60]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M01_L19
M01_L23:
       mov       rcx,r12
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFC73D97258]
       int       3
M01_L24:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFC73CE6538]
       test      eax,eax
       je        near ptr M01_L19
       mov       r10,[rsp+40]
       test      r14,r14
       je        short M01_L22
M01_L25:
       mov       rcx,r10
       call      qword ptr [7FFC7403D0B8]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L19
       mov       r10,[rsp+40]
       jmp       short M01_L22
; Total bytes of code 836
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E8
       vzeroupper
       xor       eax,eax
       mov       [rsp+98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0A0],xmm4
       vmovdqa   xmmword ptr [rsp+0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M02_L01:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rsp+1E0],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L126
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       xor       ebp,ebp
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L19
M02_L03:
       mov       ecx,ebp
       mov       r14,[rsi+rcx*8+10]
       mov       r15,[r14]
       mov       r13,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r15,r13
       jne       near ptr M02_L127
       mov       rcx,r14
       cmp       qword ptr [rcx+18],0
       jne       short M02_L05
       xor       ecx,ecx
M02_L04:
       test      rcx,rcx
       je        near ptr M02_L120
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFC73F73208]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
       jmp       short M02_L06
M02_L05:
       mov       rcx,[r14+18]
       jmp       short M02_L04
M02_L06:
       cmp       r15,r13
       jne       near ptr M02_L134
       mov       rcx,r14
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L17
M02_L07:
       mov       rdx,[r14+38]
       mov       rax,[rdx+18]
M02_L08:
       mov       r10,rax
       mov       [rsp+90],r10
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r10],rdx
       jne       near ptr M02_L136
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+170]
       mov       rcx,r10
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC73CE66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+180],0
       je        near ptr M02_L16
       cmp       dword ptr [rsp+180],1
       je        near ptr M02_L128
       mov       eax,[rsp+180]
       mov       [rsp+16C],eax
       test      eax,eax
       jl        near ptr M02_L121
       mov       r8,[rsp+170]
       mov       [rsp+68],r8
       test      r8,r8
       je        near ptr M02_L135
       cmp       [r8+8],eax
       je        short M02_L11
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+60],rax
       lea       rcx,[rax+10]
       mov       rdx,[rsp+68]
       lea       r10,[rdx+10]
       mov       edx,[rdx+8]
       mov       r9d,[rsp+16C]
       cmp       r9d,edx
       jg        short M02_L15
       mov       edx,r9d
M02_L09:
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        short M02_L13
       mov       rdx,r10
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L10:
       mov       rcx,[rsp+60]
       mov       [rsp+170],rcx
M02_L11:
       mov       ecx,[rsp+180]
       mov       [rsp+184],ecx
       mov       rax,[rsp+170]
M02_L12:
       mov       r8,rax
       jmp       short M02_L14
M02_L13:
       mov       rdx,r10
       call      qword ptr [7FFC73E45BD8]
       jmp       short M02_L10
M02_L14:
       mov       [rsp+88],r8
       test      r12,r12
       jne       near ptr M02_L20
       jmp       near ptr M02_L75
M02_L15:
       jmp       short M02_L09
M02_L16:
       mov       rdx,1E5F0C01EC0
       mov       rax,[rdx]
       jmp       short M02_L12
M02_L17:
       mov       rcx,[r14+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+78],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+78]
       mov       [rsp+1B0],rdx
       mov       [rsp+1B8],rax
       lea       rdx,[rsp+190]
       mov       [rsp+20],rdx
       mov       edx,[r14+50]
       lea       rcx,[rsp+1B0]
       lea       r8,[rsp+1A8]
       lea       r9,[rsp+1A0]
       call      qword ptr [7FFC73FE5740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+198]
       mov       [rsp+188],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+80],rax
       mov       r9,[r14+30]
       mov       rcx,rax
       mov       rdx,[rsp+188]
       mov       r8d,[rsp+190]
       call      qword ptr [7FFC73F87AC8]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r14+38]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L18:
       inc       ebp
       cmp       [rsi+8],ebp
       jg        near ptr M02_L03
M02_L19:
       mov       rdx,rdi
       mov       rcx,1E580200C60
       call      qword ptr [7FFC73D96DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rdx,rax
       mov       rcx,1E5802089B8
       mov       r8,1E5802089D0
       call      qword ptr [7FFC73D96B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,1E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L20:
       mov       rcx,1E580200020
       mov       r9,[rsp+90]
       cmp       r9,rcx
       je        near ptr M02_L46
       mov       rcx,1E5802087C0
       cmp       r9,rcx
       je        near ptr M02_L46
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r9],rcx
       jne       near ptr M02_L162
       mov       rcx,r9
       call      qword ptr [7FFC73CE7330]; System.RuntimeType.GetBaseType()
M02_L21:
       mov       rcx,1E5802021B8
       cmp       rax,rcx
       je        near ptr M02_L133
M02_L22:
       mov       rcx,1E580208828
       mov       r8,[rsp+90]
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,1E580208660
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,1E580204FC0
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,1E580208850
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,1E580205F58
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,1E580208878
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,1E5802088A0
       cmp       r8,rcx
       je        near ptr M02_L23
       mov       rcx,1E5802088C8
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,1E5802088F0
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,1E580205718
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,1E580208918
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,1E580208940
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,1E580208968
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,1E580204B88
       cmp       r8,rcx
       je        short M02_L23
       mov       rcx,1E580208990
       cmp       r8,rcx
       jne       near ptr M02_L68
M02_L23:
       xor       ecx,ecx
       mov       [rsp+1C0],rcx
       mov       rcx,1E5F0C01E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC73F69EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+1C8],rax
       test      rax,rax
       je        near ptr M02_L164
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L24:
       mov       [rsp+1D8],rdx
       mov       [rsp+1E0],eax
       xor       ecx,ecx
       mov       [rsp+1D0],ecx
       mov       byte ptr [rsp+1D4],0
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rax,[rsp+1D8]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+1E0]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L165
       mov       rcx,1E58020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+1D0]
       inc       ecx
       mov       [rsp+1D0],ecx
M02_L25:
       cmp       r15,r13
       jne       near ptr M02_L167
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L73
M02_L26:
       cmp       byte ptr [rsp+1D4],0
       jne       near ptr M02_L168
M02_L27:
       test      r15,r15
       je        near ptr M02_L168
       mov       r8d,[rsp+1D0]
       cmp       r8d,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rcx,[rsp+1D8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+1E0]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L168
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC73E45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+1D0]
       add       edx,[r15+8]
       mov       [rsp+1D0],edx
M02_L28:
       mov       edx,[rsp+1D0]
       cmp       edx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rcx,[rsp+1D8]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+1E0]
       sub       eax,edx
       cmp       eax,2
       jb        near ptr M02_L169
       mov       rdx,1E580208814
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       edx,[rsp+1D0]
       add       edx,2
       mov       [rsp+1D0],edx
M02_L29:
       mov       [rsp+0F0],r12
       cmp       byte ptr [rsp+1D4],0
       jne       near ptr M02_L132
       mov       rdx,[rsp+0F0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73D94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L92
       mov       rdx,[rsp+0F0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73D94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L72
M02_L30:
       mov       rdx,[rsp+0F0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73D943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rdx,[rsp+1D8]
       mov       r8d,ecx
       lea       r15,[rdx+r8*2]
       mov       r13d,[rsp+1E0]
       sub       r13d,ecx
       xor       r12d,r12d
       mov       rcx,offset MT_System.Int16
       cmp       [rax],rcx
       jne       near ptr M02_L40
       add       rax,8
       mov       rcx,[rsp+1C0]
       movsx     r12,word ptr [rax]
       test      r12d,r12d
       jl        near ptr M02_L42
       mov       eax,r12d
       mov       ecx,r12d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFCD2CF87A0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r13d
       jg        near ptr M02_L129
       mov       [rsp+0E0],eax
       mov       [rsp+0D8],r15
       movsxd    rcx,eax
       lea       rcx,[r15+rcx*2]
       mov       edx,r12d
       cmp       edx,0A
       jb        short M02_L33
       cmp       edx,64
       jb        short M02_L32
       mov       r9,1E5F0C00290
       mov       r15,[r9]
M02_L31:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9d,edx
       imul      r9,51EB851F
       shr       r9,25
       imul      r8d,r9d,64
       sub       edx,r8d
       mov       r8,r15
       shl       edx,2
       mov       edx,[r8+rdx+10]
       mov       [rcx],edx
       cmp       r9d,64
       mov       edx,r9d
       jae       short M02_L31
M02_L32:
       cmp       edx,0A
       jb        short M02_L33
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9,1E5F0C00290
       mov       r15,[r9]
       mov       r9,r15
       shl       edx,2
       mov       edx,[r9+rdx+10]
       mov       [rcx],edx
       jmp       short M02_L34
M02_L33:
       add       edx,30
       mov       [rcx-2],dx
M02_L34:
       xor       ecx,ecx
       mov       [rsp+0D8],rcx
       mov       eax,1
M02_L35:
       xor       ecx,ecx
       mov       [rsp+0D8],rcx
M02_L36:
       test      eax,eax
       je        near ptr M02_L170
       mov       r8d,[rsp+1D0]
       add       r8d,[rsp+0E0]
       mov       [rsp+1D0],r8d
M02_L37:
       xor       ecx,ecx
       mov       [rsp+0E8],rcx
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rax,[rsp+1D8]
       mov       [rsp+0A8],rax
       mov       [rsp+0B0],ecx
       lea       rcx,[rsp+0A8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       mov       rdx,[rsp+1C8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+1C0],ymm0
       vmovdqu   xmmword ptr [rsp+1D8],xmm0
       test      rdx,rdx
       je        short M02_L38
       mov       rcx,1E5F0C01E70
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC73F69EF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L38:
       mov       rdx,r14
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short M02_L39
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L171
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L39:
       mov       rcx,rdi
       call      qword ptr [7FFC73E4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L40:
       mov       rcx,rax
       mov       [rsp+98],r15
       mov       [rsp+0A0],r13d
       mov       [rsp+0A8],r12
       xor       edx,edx
       mov       [rsp+0B0],edx
       mov       rdx,[rsp+1C0]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+98]
       lea       r9,[rsp+0A8]
       lea       r8,[rsp+0E0]
       mov       r11,7FFC73C50620
       call      qword ptr [r11]
       jmp       near ptr M02_L36
M02_L41:
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rax,[rsp+1D8]
       mov       [rsp+0A8],rax
       mov       [rsp+0B0],ecx
       lea       rcx,[rsp+0A8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       mov       r15,[rsp+1C8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+1C0],ymm0
       vmovdqu   xmmword ptr [rsp+1D8],xmm0
       test      r15,r15
       je        short M02_L45
       jmp       near ptr M02_L62
M02_L42:
       test      rcx,rcx
       jne       short M02_L44
       call      qword ptr [7FFC73EBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L43:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M02_L103
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M02_L104
M02_L44:
       call      qword ptr [7FFC73EBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L43
M02_L45:
       mov       rdx,r14
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L61
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L46:
       xor       ecx,ecx
       mov       [rsp+1C0],rcx
       mov       rcx,1E5F0C01E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC73F69EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+1C8],rax
       test      rax,rax
       je        near ptr M02_L82
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L47:
       mov       [rsp+1D8],rdx
       mov       [rsp+1E0],eax
       xor       ecx,ecx
       mov       [rsp+1D0],ecx
       mov       byte ptr [rsp+1D4],0
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rax,[rsp+1D8]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+1E0]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L83
       mov       rcx,1E58020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+1D0]
       inc       ecx
       mov       [rsp+1D0],ecx
M02_L48:
       cmp       r15,r13
       jne       near ptr M02_L85
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L70
M02_L49:
       cmp       byte ptr [rsp+1D4],0
       jne       near ptr M02_L86
M02_L50:
       test      r15,r15
       je        near ptr M02_L86
       mov       r8d,[rsp+1D0]
       cmp       r8d,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rcx,[rsp+1D8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+1E0]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L86
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC73E45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+1D0]
       add       edx,[r15+8]
       mov       [rsp+1D0],edx
M02_L51:
       mov       edx,[rsp+1D0]
       cmp       edx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rcx,[rsp+1D8]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+1E0]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L87
       mov       rdx,1E5802087F4
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rsp+1D0]
       add       edx,3
       mov       [rsp+1D0],edx
M02_L52:
       mov       [rsp+150],r12
       cmp       byte ptr [rsp+1D4],0
       jne       near ptr M02_L131
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73D94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L98
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73D94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L69
M02_L53:
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC73D943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rdx,[rsp+1D8]
       mov       r8d,ecx
       lea       r13,[rdx+r8*2]
       mov       r12d,[rsp+1E0]
       sub       r12d,ecx
       xor       r14d,r14d
       mov       rcx,offset MT_System.Int16
       cmp       [rax],rcx
       jne       near ptr M02_L93
       add       rax,8
       mov       rcx,[rsp+1C0]
       movsx     r14,word ptr [rax]
       test      r14d,r14d
       jl        near ptr M02_L65
       mov       eax,r14d
       mov       ecx,r14d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFCD2CF87A0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M02_L130
       mov       [rsp+140],eax
       mov       [rsp+138],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       edx,r14d
       cmp       edx,0A
       jb        short M02_L56
       cmp       edx,64
       jb        short M02_L55
       mov       r9,1E5F0C00290
       mov       r15,[r9]
M02_L54:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9d,edx
       imul      r9,51EB851F
       shr       r9,25
       imul      r8d,r9d,64
       sub       edx,r8d
       mov       r8,r15
       shl       edx,2
       mov       edx,[r8+rdx+10]
       mov       [rcx],edx
       cmp       r9d,64
       mov       edx,r9d
       jae       short M02_L54
M02_L55:
       cmp       edx,0A
       jb        short M02_L56
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9,1E5F0C00290
       mov       r15,[r9]
       shl       edx,2
       mov       edx,[r15+rdx+10]
       mov       [rcx],edx
       jmp       short M02_L57
M02_L56:
       add       edx,30
       mov       [rcx-2],dx
M02_L57:
       xor       ecx,ecx
       mov       [rsp+138],rcx
       mov       eax,1
M02_L58:
       xor       ecx,ecx
       mov       [rsp+138],rcx
M02_L59:
       test      eax,eax
       je        near ptr M02_L88
       mov       r8d,[rsp+1D0]
       add       r8d,[rsp+140]
       mov       [rsp+1D0],r8d
M02_L60:
       xor       ecx,ecx
       mov       [rsp+148],rcx
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rax,[rsp+1D8]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+1E0]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L141
       mov       rcx,1E58020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+1D0]
       inc       ecx
       mov       [rsp+1D0],ecx
       jmp       near ptr M02_L41
M02_L61:
       mov       rcx,rdi
       call      qword ptr [7FFC73E4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L62:
       mov       rcx,1E5F0C01E70
       mov       r12,[rcx]
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFC73CD5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L142
M02_L63:
       xor       eax,eax
       mov       dword ptr [rsp+130],1
       cmp       [rcx+8],r13d
       jbe       short M02_L64
       mov       dword ptr [rsp+134],1
       mov       edx,10
       shlx      edx,edx,r13d
       cmp       [r15+8],edx
       jne       near ptr M02_L122
       mov       edx,r13d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+48],r10
       mov       r9,[r10]
       mov       [rsp+40],r9
       mov       rcx,r10
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       edx,edx
       mov       rcx,[rsp+48]
       mov       [rcx+8],edx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+134]
       jne       near ptr M02_L143
M02_L64:
       mov       rdx,1E5F0C005D0
       mov       r10,[rdx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L157
       jmp       near ptr M02_L45
M02_L65:
       test      rcx,rcx
       jne       short M02_L67
       call      qword ptr [7FFC73EBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M02_L66:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M02_L89
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M02_L90
M02_L67:
       call      qword ptr [7FFC73EBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M02_L66
M02_L68:
       mov       rax,1E580203C30
       cmp       r8,rax
       jne       near ptr M02_L112
       cmp       r15,r13
       jne       near ptr M02_L108
       mov       r13,r14
       mov       r15,[r13+8]
       test      r15,r15
       jne       near ptr M02_L77
       jmp       near ptr M02_L76
M02_L69:
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73D943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+1C0]
       mov       r11,7FFC73C50608
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L101
M02_L70:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L84
       mov       rcx,r15
       call      qword ptr [7FFC73E45050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L71:
       mov       [rsp+158],r15
       mov       [rsp+160],eax
       lea       rcx,[rsp+158]
       call      qword ptr [7FFC73F86B98]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L49
M02_L72:
       mov       rdx,[rsp+0F0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC73D943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+1C0]
       mov       r11,7FFC73C50618
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L96
M02_L73:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L166
       mov       rcx,r15
       call      qword ptr [7FFC73E45050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L74:
       mov       [rsp+0F8],r15
       mov       [rsp+100],eax
       lea       rcx,[rsp+0F8]
       call      qword ptr [7FFC73F86B98]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L26
M02_L75:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,1E580208780
       mov       r8,1E580208798
       call      qword ptr [7FFC73D96B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M02_L81
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L76:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0C8],xmm0
       mov       rdx,[r13+48]
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC73F86B20]
       vmovups   xmm0,[rsp+0C8]
       vmovups   [rsp+0B8],xmm0
       lea       rcx,[rsp+0B8]
       call      qword ptr [7FFC73F86B98]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L77:
       mov       rax,offset MT_System.Boolean
       cmp       [r12],rax
       jne       near ptr M02_L109
       add       r12,8
       cmp       byte ptr [r12],0
       je        near ptr M02_L137
       mov       r12,1E580208A08
M02_L78:
       cmp       [r12],r12b
       call      qword ptr [7FFC73ED4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       near ptr M02_L102
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC73EACFF8]; System.Globalization.CultureInfo.get_TextInfo()
M02_L79:
       cmp       [rax],al
       test      r12,r12
       je        near ptr M02_L123
       mov       rcx,rax
       mov       rdx,r12
       call      qword ptr [7FFC741943C0]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       r12,rax
       test      r15,r15
       je        near ptr M02_L110
       cmp       dword ptr [r15+8],0
       je        near ptr M02_L110
       test      r12,r12
       je        near ptr M02_L111
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L111
       mov       ecx,[r15+8]
       mov       eax,[r12+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L124
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,1E58020878C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC73E45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r13+r8*2+0C]
       mov       rcx,1E580208814
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r15+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r13+r8*2+0C]
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFC73E45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r13
M02_L80:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L91
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L171
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L81:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC73E4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L82:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L47
M02_L83:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E580208780
       call      qword ptr [7FFC73EB58F0]
       jmp       near ptr M02_L48
M02_L84:
       xor       eax,eax
       jmp       near ptr M02_L71
M02_L85:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+1D4],0
       je        near ptr M02_L50
M02_L86:
       lea       rcx,[rsp+1C0]
       mov       rdx,r15
       call      qword ptr [7FFC73EB5848]
       jmp       near ptr M02_L51
M02_L87:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E5802087E8
       call      qword ptr [7FFC73EB58F0]
       jmp       near ptr M02_L52
M02_L88:
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFC73EB5938]
       jmp       near ptr M02_L53
M02_L89:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M02_L90:
       mov       ecx,r14d
       mov       [rsp+0A8],r8
       mov       [rsp+0B0],r9d
       mov       [rsp+98],r13
       mov       [rsp+0A0],r12d
       lea       r8,[rsp+140]
       mov       [rsp+20],r8
       lea       r8,[rsp+0A8]
       lea       r9,[rsp+98]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC7440D410]
       jmp       near ptr M02_L59
M02_L91:
       mov       rcx,rdi
       call      qword ptr [7FFC73E4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L92:
       xor       r8d,r8d
       mov       [rsp+0E8],r8
       lea       r14,[rsp+0F0]
       cmp       qword ptr [rsp+0E8],0
       jne       short M02_L94
       jmp       near ptr M02_L97
M02_L93:
       mov       rcx,rax
       mov       [rsp+98],r13
       mov       [rsp+0A0],r12d
       mov       [rsp+0A8],r14
       xor       edx,edx
       mov       [rsp+0B0],edx
       mov       rdx,[rsp+1C0]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+98]
       lea       r9,[rsp+0A8]
       lea       r8,[rsp+140]
       mov       r11,7FFC73C50610
       call      qword ptr [r11]
       jmp       near ptr M02_L59
M02_L94:
       mov       rcx,[r14]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L106
       cmp       [rcx],cl
M02_L95:
       mov       r15,rcx
M02_L96:
       test      r15,r15
       je        near ptr M02_L37
       mov       r8d,[rsp+1D0]
       cmp       r8d,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rcx,[rsp+1D8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+1E0]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L107
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC73E45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+1D0]
       add       ecx,[r15+8]
       mov       [rsp+1D0],ecx
       jmp       near ptr M02_L37
M02_L97:
       mov       rcx,[r14]
       mov       [rsp+0E8],rcx
       lea       r14,[rsp+0E8]
       cmp       qword ptr [rsp+0E8],0
       je        near ptr M02_L105
       jmp       near ptr M02_L94
M02_L98:
       xor       r8d,r8d
       mov       [rsp+148],r8
       lea       r8,[rsp+150]
       cmp       qword ptr [rsp+148],0
       jne       short M02_L99
       mov       r8,[r8]
       mov       [rsp+148],r8
       lea       r8,[rsp+148]
       cmp       qword ptr [rsp+148],0
       je        near ptr M02_L138
M02_L99:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L139
M02_L100:
       mov       rdx,rcx
M02_L101:
       test      rdx,rdx
       je        near ptr M02_L60
       mov       r8d,[rsp+1D0]
       cmp       r8d,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rcx,[rsp+1D8]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+1E0]
       sub       eax,r8d
       mov       r14d,[rdx+8]
       cmp       r14d,eax
       ja        near ptr M02_L140
       add       rdx,0C
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFC73E45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rsp+1D0]
       mov       [rsp+1D0],r14d
       jmp       near ptr M02_L60
M02_L102:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       jmp       near ptr M02_L79
M02_L103:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M02_L104:
       mov       ecx,r12d
       mov       [rsp+0A8],r8
       mov       [rsp+0B0],r9d
       mov       [rsp+98],r15
       mov       [rsp+0A0],r13d
       lea       r8,[rsp+0E0]
       mov       [rsp+20],r8
       lea       r8,[rsp+0A8]
       lea       r9,[rsp+98]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC7440D410]
       jmp       near ptr M02_L36
M02_L105:
       xor       r15d,r15d
       jmp       near ptr M02_L96
M02_L106:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L95
M02_L107:
       lea       rcx,[rsp+1C0]
       mov       rdx,r15
       call      qword ptr [7FFC73EB58F0]
       jmp       near ptr M02_L37
M02_L108:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
M02_L109:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M02_L78
M02_L110:
       mov       r8,r12
       mov       rcx,1E580208780
       mov       rdx,1E580208808
       call      qword ptr [7FFC73D96B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L80
M02_L111:
       mov       rdx,r15
       mov       rcx,1E580208780
       mov       r8,1E580208808
       call      qword ptr [7FFC73D96B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L80
M02_L112:
       lea       rcx,[rsp+1C0]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFC73EB56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rdx,[rsp+1D8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+1E0]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L113
       mov       rcx,1E58020878C
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+1D0]
       inc       ecx
       mov       [rsp+1D0],ecx
       jmp       short M02_L114
M02_L113:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E580208780
       call      qword ptr [7FFC73EB58F0]
M02_L114:
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFC73EB5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rdx,[rsp+1D8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+1E0]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L115
       mov       rcx,1E5802087F4
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rsp+1D0]
       add       ecx,3
       mov       [rsp+1D0],ecx
       jmp       short M02_L116
M02_L115:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E5802087E8
       call      qword ptr [7FFC73EB58F0]
M02_L116:
       lea       rcx,[rsp+1C0]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFC74016EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+1D0]
       cmp       ecx,[rsp+1E0]
       ja        near ptr M02_L125
       mov       rdx,[rsp+1D8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+1E0]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L117
       mov       rcx,1E58020878C
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+1D0]
       inc       ecx
       mov       [rsp+1D0],ecx
       jmp       short M02_L118
M02_L117:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E580208780
       call      qword ptr [7FFC73EB58F0]
M02_L118:
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFC73EB5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L119
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M02_L171
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L119:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC73E4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L120:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC74385410]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC73D9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L121:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC73F2ED48]
       int       3
M02_L122:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC74387690]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC73C44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC73D9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L123:
       mov       ecx,16EB
       mov       rdx,7FFC73C44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC73F566E8]
       int       3
M02_L124:
       call      qword ptr [7FFC73F2EF40]
       int       3
M02_L125:
       call      qword ptr [7FFC73F2E9D0]
       int       3
       call      CORINFO_HELP_OVERFLOW
M02_L126:
       mov       rcx,1E5F0C01E90
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L127:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r15+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M02_L06
M02_L128:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+70],rax
       mov       rcx,rax
       mov       r8,[rsp+178]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rsp+70]
       jmp       near ptr M02_L12
M02_L129:
       xor       ecx,ecx
       mov       [rsp+0E0],ecx
       xor       eax,eax
       jmp       near ptr M02_L35
M02_L130:
       xor       ecx,ecx
       mov       [rsp+140],ecx
       xor       eax,eax
       jmp       near ptr M02_L58
M02_L131:
       lea       rcx,[rsp+1C0]
       mov       r8,[rsp+150]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC7438FB58]
       jmp       near ptr M02_L60
M02_L132:
       lea       rcx,[rsp+1C0]
       mov       r8,[rsp+0F0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC7438FB58]
       jmp       near ptr M02_L37
M02_L133:
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L22
       mov       rcx,[rsp+88]
       mov       rdx,r12
       call      qword ptr [7FFC74194330]
       mov       r13,rax
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r13
       mov       rcx,1E580208780
       mov       r8,1E580208808
       call      qword ptr [7FFC73D96B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M02_L163
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L18
M02_L134:
       mov       rcx,r14
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M02_L08
M02_L135:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+170],rax
       jmp       near ptr M02_L11
M02_L136:
       mov       rcx,r10
       mov       edx,1C
       mov       rax,[r10]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L14
M02_L137:
       mov       r12,1E5802089E8
       jmp       near ptr M02_L78
M02_L138:
       xor       edx,edx
       jmp       near ptr M02_L101
M02_L139:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L100
M02_L140:
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFC73EB58F0]
       jmp       near ptr M02_L60
M02_L141:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E580208780
       call      qword ptr [7FFC73EB58F0]
       jmp       near ptr M02_L41
M02_L142:
       mov       rcx,r12
       call      qword ptr [7FFC73F5D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L63
M02_L143:
       mov       rcx,[r12+10]
       cmp       r13d,[rcx+8]
       jae       near ptr M02_L171
       mov       edx,r13d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+134],eax
       jne       short M02_L144
       mov       rcx,r12
       mov       edx,r13d
       call      qword ptr [7FFC73F5D7E8]
       mov       r10,rax
M02_L144:
       mov       r10,[r10+8]
       mov       [rsp+38],r10
       mov       rcx,7FFC73CD5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC73CD5C38],0
       je        short M02_L145
       call      qword ptr [7FFC73D9DC98]
       mov       edx,eax
       mov       [rsp+118],edx
       jmp       short M02_L148
M02_L145:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+114],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+114]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L146
       call      qword ptr [7FFC743B4498]
       mov       edx,eax
       jmp       short M02_L147
M02_L146:
       mov       edx,ecx
       sar       edx,10
M02_L147:
       mov       [rsp+118],edx
M02_L148:
       mov       rcx,7FFC73CD5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+118]
       xor       edx,edx
       div       dword ptr [7FFC73CD5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L155
M02_L149:
       cmp       eax,[r8+8]
       jae       near ptr M02_L171
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+110],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+10C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L151
       test      r10d,r10d
       jne       short M02_L152
       xor       edx,edx
       mov       [rax+14],edx
M02_L150:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M02_L151:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+110]
       test      ecx,ecx
       je        short M02_L153
       mov       r8d,1
       jmp       short M02_L156
M02_L152:
       jmp       short M02_L150
M02_L153:
       mov       eax,[rsp+120]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M02_L154
       xor       r8d,r8d
M02_L154:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,r8d
M02_L155:
       mov       r8,[rsp+38]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L149
       xor       r8d,r8d
M02_L156:
       mov       eax,r8d
       mov       [rsp+130],eax
       mov       eax,[rsp+134]
       jmp       near ptr M02_L64
M02_L157:
       cmp       dword ptr [r15+8],0
       mov       [rsp+134],eax
       mov       [rsp+58],r10
       je        near ptr M02_L45
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+12C],eax
       mov       edx,[r15+8]
       mov       [rsp+128],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+12C]
       mov       r9d,[rsp+128]
       mov       edx,3
       call      qword ptr [7FFC73E47678]
       mov       eax,[rsp+134]
       test      [rsp+130],eax
       mov       [rsp+134],eax
       jne       near ptr M02_L45
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[r15+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+124],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rsp+134]
       test      r12d,r12d
       jne       short M02_L158
       mov       r13,[rsp+50]
       mov       edx,[rsp+124]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L159
M02_L158:
       mov       rdx,[rsp+50]
       mov       ecx,[rsp+124]
       mov       r8d,ecx
       mov       ecx,r13d
       mov       r13,rdx
       mov       edx,r8d
M02_L159:
       mov       r8d,r15d
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L160
       mov       eax,1
       jmp       short M02_L161
M02_L160:
       xor       eax,eax
M02_L161:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r13
       call      qword ptr [7FFC73F5E2B0]
       jmp       near ptr M02_L45
M02_L162:
       mov       rcx,r9
       mov       rax,[r9]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L21
M02_L163:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC73E4E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L18
M02_L164:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L24
M02_L165:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E580208780
       call      qword ptr [7FFC73EB58F0]
       jmp       near ptr M02_L25
M02_L166:
       xor       eax,eax
       jmp       near ptr M02_L74
M02_L167:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+1D4],0
       je        near ptr M02_L27
M02_L168:
       lea       rcx,[rsp+1C0]
       mov       rdx,r15
       call      qword ptr [7FFC73EB5848]
       jmp       near ptr M02_L28
M02_L169:
       lea       rcx,[rsp+1C0]
       mov       rdx,1E580208808
       call      qword ptr [7FFC73EB58F0]
       jmp       near ptr M02_L29
M02_L170:
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFC73EB5938]
       jmp       near ptr M02_L30
M02_L171:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 7723
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.NewtonsoftValueMapping()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,17020801E78
       mov       rsi,[rax]
       call      qword ptr [7FFC741D6D18]; Newtonsoft.Json.JsonSerializer.CreateDefault()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC741D4738]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0D3172402
       mov       r9d,6C29C156
       call      qword ptr [7FFC74355F68]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; Newtonsoft.Json.JsonSerializer.CreateDefault()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,17020804E38
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFC741D6CD0]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbx,rbx
       jne       short M01_L03
M01_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC741D6D48]
       jmp       short M01_L01
; Total bytes of code 94
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,17020800428
       mov       r13,[rcx]
       mov       rcx,170208014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17000201C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,17020805028
       mov       rax,17020805030
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFC741CAC00
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC73E8D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFC74019968]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFC741DEDF0]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFC73C90CE8
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.TextJsonValueMapping()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rax,165A5001E78
       mov       rax,[rax]
       mov       [rsp+38],rax
       call      qword ptr [7FFC741C53E0]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L03
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rdx,[rdi+0B8]
       mov       r8,16580308758
       cmp       rdx,r8
       jne       short M00_L04
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L05
M00_L02:
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.ValueTestObject ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFC741C6FD0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0F1CA6A48
       mov       r9d,0BAF1C12B
       call      qword ptr [7FFC74285140]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC741C5A10]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L04:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,16580308758
       mov       r8d,1
       call      qword ptr [7FFC741C52C0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC73DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 274
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,165A5004EF8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,165A5004EF8
       xor       edx,edx
       jmp       qword ptr [7FFC741C5AB8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC741C5A88]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M02_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M02_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M02_L12
M02_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M02_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,165A5001F88
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFC743A7BB0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M02_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M02_L02
M02_L01:
       mov       edx,2
M02_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M02_L13
       mov       rdi,16580301C08
M02_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M02_L14
M02_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC741C6D90]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M02_L08
       cmp       [rcx+8],r15d
       jb        short M02_L07
M02_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M02_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M02_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M02_L06:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M02_L07
       mov       r12d,r15d
       jmp       short M02_L10
M02_L07:
       call      qword ptr [7FFC73F5E9D0]
       int       3
M02_L08:
       test      r15d,r15d
       jne       short M02_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M02_L05
M02_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M02_L06
M02_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFC741CD908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M02_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M02_L00
M02_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFC7439D1E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L13:
       mov       rcx,7FFC741BC718
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,165A5004F38
       mov       rdi,[rcx]
       jmp       near ptr M02_L03
M02_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFC74396748]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M02_L04
M02_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFC7439CCF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFC743968C8]
       mov       r14,r13
       jmp       near ptr M02_L04
M02_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M02_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L18
M02_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L19
M02_L18:
       mov       rax,[rcx]
       add       rax,10
M02_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M02_L20
       test      r10d,r10d
       jne       short M02_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M02_L23
M02_L20:
       cmp       [rcx+8],r10d
       jae       short M02_L22
M02_L21:
       call      qword ptr [7FFC73F5E9D0]
       int       3
M02_L22:
       add       rcx,10
M02_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M02_L25
       cmp       rdx,300
       ja        short M02_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFC73E75BA8]
M02_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,165A5001F88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC743A7BB8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1184
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M04_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M04_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFC741C4828]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M04_L05
       call      qword ptr [7FFC741C75E8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M04_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFC73DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M04_L03
       jmp       near ptr M04_L09
M04_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L09
M04_L03:
       call      qword ptr [7FFC741C77F8]
       test      eax,eax
       je        near ptr M04_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFC74284450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFC74284450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFC74284480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC741C76C0]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M04_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74284318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M04_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74284318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M04_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74284318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC741C5A10]
       jmp       short M04_L09
M04_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74284390]
       jmp       short M04_L09
M04_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M04_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFC73DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M04_L07
M04_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M04_L08
M04_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M04_L08:
       cmp       dword ptr [rbp-34],0
       je        short M04_L09
       call      qword ptr [7FFC741CC978]
M04_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC741C59C8]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M05_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC741C5278]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC74284360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M05_L01
       cmp       qword ptr [rbp-8],0
       je        short M05_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC741C66A0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M05_L01
M05_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M05_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC741C5A28]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M05_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M05_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC74084720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M05_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC741C5488]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC741CCF60]
M05_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M06_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M06_L02
M06_L01:
       mov       rax,rdx
       ret
M06_L02:
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       jne       short M06_L00
M06_L03:
       lea       rax,[7FFCD375B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

